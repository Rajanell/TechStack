using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Client.Store.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Client.Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Products");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(UserRequest model)
        {
            if (ModelState.IsValid)
            {
                var user = System.Text.Json.JsonSerializer.Serialize(model);

                var httpClient = _httpClientFactory.CreateClient("APIClient");
                var request = new HttpRequestMessage(HttpMethod.Post, $"/api/User")
                {
                    Content = new StringContent(user, System.Text.Encoding.Unicode, "application/json")
                };

                var response = await httpClient.SendAsync(
                    request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    return View("RegistrationConfirmation");
                }
                else
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var errors = JsonConvert.DeserializeObject<APIErrors>(responseContent);

                   foreach(var modelState in errors.errors)
                    {
                        var modelField = modelState.Key;
                        foreach(var fieldError in modelState.Value)
                        {
                            ModelState.AddModelError(modelField, fieldError);
                        }
                    }
                }
            }
            return View(model);
        }
        public IActionResult RegistrationConfirmation()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Sale()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
    public class APIErrors
    {
        public Dictionary<string, IList<string>> errors { get; set; }

    }
}
