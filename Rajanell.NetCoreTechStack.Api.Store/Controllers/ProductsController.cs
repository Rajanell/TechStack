using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Query.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.API.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IMessageService messageService;

        public ProductsController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll([FromQuery] ProductSearchRequest request)
        {
            var results = await messageService.Send(new GetAllProductQuery { QueryData = request});
            return Ok(results);
        }
        [HttpGet]
        [Route("Cart")]
        public async Task<IActionResult> GetProductsInCart(string cartItems)
        {
            var results = await messageService.Send(new GetCartProductsQuery { QueryData = cartItems });
            return Ok(results);
        }
    }
}
