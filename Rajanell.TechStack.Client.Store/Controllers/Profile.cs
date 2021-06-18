using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Client.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Client.Store.Controllers
{
    [Authorize]
    public class Profile : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<Products> _logger;

        public Profile(IHttpClientFactory httpClientFactory, ILogger<Products> logger)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            //get logged in user
            var userId = User.FindFirst(ClaimTypes.NameIdentifier);
            var httpClient = _httpClientFactory.CreateClient("APIClient");

            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Orders?userId={userId.Value}");

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var results = JsonSerializer.Deserialize<CommandResultViewModel<List<Order>>>(responseContent, 
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                return View(results.Resource);
            }
            return View(new List<Order>());
        }
        public async Task<IActionResult> PlaceOrder()
        {
            //get logged in user
            var userId = User.FindFirst(ClaimTypes.NameIdentifier);
            var stringCartItems = Request.Cookies["Cart"];
            List<Guid> cartItems = stringCartItems.Split(';').ToList().Select(s => Guid.Parse(s)).ToList();
            var orderRequest = new OrderRequest { UserId = userId.Value, CartItems = cartItems };

            var order = JsonSerializer.Serialize(orderRequest);

            var httpClient = _httpClientFactory.CreateClient("APIClient");
            var request = new HttpRequestMessage(HttpMethod.Post, $"/api/Orders")
            {
                Content = new StringContent(order, System.Text.Encoding.Unicode, "application/json")
            };

            var response = await httpClient.SendAsync(
                request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            response.EnsureSuccessStatusCode();

            //delete cart
            Response.Cookies.Append("Cart", string.Empty);
            //Send an Email


            //Go to profile
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Checkout()
        {
            var cartItems = Request.Cookies["Cart"];

            var httpClient = _httpClientFactory.CreateClient("APIClient");
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Products/Cart?cartItems={cartItems}");
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var results = JsonSerializer.Deserialize<CommandResultViewModel<List<ProductResponse>>>(responseContent,
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });

                List<Guid> productIds = cartItems.Split(';').ToList().Select(s => Guid.Parse(s)).ToList();
                List<ProductViewModel> productViewModels = new List<ProductViewModel>();
                foreach (var product in results.Resource)
                {
                    var count = productIds.Where(x => x == product.ProductId).Count();

                    productViewModels.Add(new ProductViewModel
                    {
                        Description = product.Description,
                        Image = product.Image,
                        Name = product.Name,
                        Price = product.Price,
                        ProductCategoryId = product.ProductCategoryId,
                        ProductId = product.ProductId,
                        Tags = product.Tags,

                        TotalPrice = count * product.Price,
                        Quantity = count
                    });
                }

                var model = new CartViewModel
                {
                    Products = productViewModels,
                    TotalPrice = productViewModels.Sum(x => x.TotalPrice)
                };

                return View(model);
            }
            return View();
        }

        public async Task Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}
