using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Phonebook.Application.Events;
using Rajanell.TechStack.Phonebook.Core.Model.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.API.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PhonebookController : ControllerBase
    {
        private readonly IMessageService messageService;

        public PhonebookController(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll([FromQuery] PhoneBookSearchRequest request)
        {
            var results = await messageService.Send(new FindPhoneBookQuery { QueryData = request });
            return Ok(results);
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] PhoneBookRequest request)
        {
            var results = await messageService.Send(new AddPhoneBookCommand { CommandData = request });
            return Ok(results);
        }
        [HttpPost]
        [Route("Entry")]
        public async Task<IActionResult> CreateEntry([FromBody] PhoneBookEntryRequest request)
        {
            var results = await messageService.Send(new AddPhoneBookEntryCommand { CommandData = request });
            return Ok(results);
        }
        [HttpGet]
        [Route("Search")]
        public async Task<IActionResult> Search(string request)
        {
            var results = await messageService.Send(new FindPhoneBookEntryQuery { QueryData = request });
            return Ok(results);
        }
    }
}
