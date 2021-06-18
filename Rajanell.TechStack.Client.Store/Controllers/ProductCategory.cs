using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model;
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
    public class ProductCategory : Controller
    {
        private readonly ILogger<ProductCategory> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductCategory(ILogger<ProductCategory> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var httpClient = _httpClientFactory.CreateClient("APIClient");
            var request = new HttpRequestMessage(HttpMethod.Get, "/api/ProductCategory");
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var results = JsonSerializer.Deserialize<CommandResultViewModel<List<ProductCategoryResponse>>>(responseContent, 
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });              
                return PartialView(results.Resource);
            }

            return PartialView();
        }
    }
}
