using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Client.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Client.Store.Controllers
{
    public class Products : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<Products> _logger;

        public Products(IHttpClientFactory httpClientFactory, ILogger<Products> logger)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
            _logger = logger;
        }

        public async Task<IActionResult> Index(string categoryId)
        {
            var httpClient = _httpClientFactory.CreateClient("APIClient");

            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Products?Search={categoryId}");

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var results = JsonSerializer.Deserialize<CommandResultViewModel<List<ProductResponse>>>(responseContent, 
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                return View(results.Resource);
            }
            return View(new List<ProductResponse>());
        }
        public IActionResult AddToCart(string productId)
        {
            var products = Request.Cookies["Cart"];
            if(string.IsNullOrEmpty(products))
            {
                Response.Cookies.Append("Cart", productId);
                return RedirectToAction("Cart", new { cartItems = productId});
            }

            List<string> CartProducts = products.Split(';').ToList();
            CartProducts.Add(productId);
            Response.Cookies.Append("Cart", string.Join(";", CartProducts));
            return RedirectToAction("Cart", new { cartItems = string.Join(";", CartProducts) });
        }
        public IActionResult RemoveFromCart(string productId)
        {
            var products = Request.Cookies["Cart"];
            if (string.IsNullOrEmpty(products))
                return View("Cart", new CartViewModel());

            List<string> productIds = products.Split(';').ToList();
            productIds.Remove(productId);
            Response.Cookies.Append("Cart", string.Join(";", productIds));

            if (productIds.Any())
               return RedirectToAction("Cart", new { cartItems = string.Join(";", productIds) });
            else
                return View("Cart", new CartViewModel());
        }
        public IActionResult ViewCart()
        {
            var products = Request.Cookies["Cart"];
            if (!string.IsNullOrEmpty(products))
                return RedirectToAction("Cart", new { cartItems = products });            

            return View("Cart",new CartViewModel());
        }

        public async Task<IActionResult> Cart(string cartItems)
        {
            var httpClient = _httpClientFactory.CreateClient("APIClient");
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Products/Cart?cartItems={cartItems}");
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

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

                    productViewModels.Add(new ProductViewModel { 
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
    }
}
