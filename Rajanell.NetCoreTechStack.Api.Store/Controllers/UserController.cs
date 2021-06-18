using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Command.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.API.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IMessageService messageService;

        public UserController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] UserRequest request)
        {
            var results = await messageService.Send(new AddUserCommand { CommandData = request });
            return Ok(results);
        }
    }
}
