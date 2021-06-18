using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Command.Order;
using Rajanell.TechStack.Application.Events.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.API.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly IMessageService messageService;

        public OrdersController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll(string userId)
        {
            var results = await messageService.Send(new GetUserOrdersQuery { QueryData = userId });
            return Ok(results);
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] OrderRequest request)
        {
            var results = await messageService.Send(new PlaceOrderCommand { CommandData = request });
            return Ok(results);
        }
    }
}
