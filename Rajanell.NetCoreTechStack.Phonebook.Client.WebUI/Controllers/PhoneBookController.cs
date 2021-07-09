using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Phonebook.Client.WebUI.Models;
using Rajanell.TechStack.Phonebook.Core.Model.RequestDTO;
using Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rajanell.NetCoreTechStack.Phonebook.Client.WebUI.Controllers
{
    public class PhoneBookController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<PhoneBookController> _logger;

        public PhoneBookController(IHttpClientFactory httpClientFactory, ILogger<PhoneBookController> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<IActionResult> Index(string phonebookId, string searchString)
        {
            var httpClient = _httpClientFactory.CreateClient("APIClient");

            var url = "/api/Phonebook" + (string.IsNullOrEmpty(phonebookId) ? "" : $"PhoneBookId={phonebookId}");          
            url = url +  (string.IsNullOrEmpty(searchString) ? "" : (string.IsNullOrEmpty(phonebookId) ? $"?SearchString={searchString}" : $"&SearchString={searchString}"));

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var results = JsonSerializer.Deserialize<CommandResultViewModel<List<PhoneBookResponse>>>(responseContent,
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                return View(results.Resource);
            }
            return View(new List<PhoneBookResponse>());
        }
        public async Task<IActionResult> Details(string phonebookId)
        {
            var httpClient = _httpClientFactory.CreateClient("APIClient");

            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Phonebook?PhoneBookId={phonebookId}");

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var results = JsonSerializer.Deserialize<CommandResultViewModel<List<PhoneBookResponse>>>(responseContent,
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                return View(results.Resource.FirstOrDefault());
            }
            return View(new List<PhoneBookResponse>());
        }
        public async Task<IActionResult> AddPhonebook(string phonebookName)
        {
            if (ModelState.IsValid)
            {
                var user = JsonSerializer.Serialize( new PhoneBookRequest { Name = phonebookName });

                var httpClient = _httpClientFactory.CreateClient("APIClient");
                var request = new HttpRequestMessage(HttpMethod.Post, $"/api/PhoneBook")
                {
                    Content = new StringContent(user, System.Text.Encoding.Unicode, "application/json")
                };

                var response = await httpClient.SendAsync(
                    request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    //var responseContent = await response.Content.ReadAsStringAsync();
                    //var errors = JsonConvert.DeserializeObject<APIErrors>(responseContent);

                    //foreach (var modelState in errors.errors)
                    //{
                    //    var modelField = modelState.Key;
                    //    foreach (var fieldError in modelState.Value)
                    //    {
                    //        ModelState.AddModelError(modelField, fieldError);
                    //    }
                    //}
                }
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> AddPhonebookEntry(string phonebookId, string name, string phonenumber)
        {
         
                var user = JsonSerializer.Serialize(new PhoneBookEntryRequest { Name = name, PhoneBookId = Guid.Parse(phonebookId), PhoneNumber = phonenumber  });

                var httpClient = _httpClientFactory.CreateClient("APIClient");
                var request = new HttpRequestMessage(HttpMethod.Post, $"/api/PhoneBook/Entry")
                {
                    Content = new StringContent(user, System.Text.Encoding.Unicode, "application/json")
                };

                var response = await httpClient.SendAsync(
                    request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Details", new { phonebookId = phonebookId });
            }
            return RedirectToAction("Details", new { phonebookId = phonebookId });
        }
        public async Task<IActionResult> Search(string searchString)
        {
            var httpClient = _httpClientFactory.CreateClient("APIClient");
            var request = new HttpRequestMessage(HttpMethod.Get, $"/api/Phonebook/Search?request={searchString}");

            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var results = JsonSerializer.Deserialize<CommandResultViewModel<List<PhoneBookEntryResponse>>>(responseContent,
                    new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
                return View(results.Resource);
            }
            return View(new List<PhoneBookEntryResponse>());
        }
    }
}
