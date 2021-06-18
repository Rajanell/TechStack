using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Command.ProductCategory;
using Rajanell.TechStack.Application.Events.Query.ProductCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.API.Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IMessageService messageService;

        public ProductCategoryController(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> Get(Guid request)
        {
            var results = await messageService.Send(new GetProductCategoryByIdQuery { QueryData = request });
            return Ok(results);
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAll()
        {
            var results = await messageService.Send(new GetAllProductCategoriesQuery { QueryData = null });
            return Ok(results);
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create([FromBody] ProductCategoryRequest request)
        {
            var results = await messageService.Send(new AddProductCategoryCommand { CommandData = request });
            return Ok(results);
        }
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> Update(ProductCategoryUpdateRequest request)
        {
            var results = await messageService.Send(new UpdateProductCategoryCommand { CommandData = request });
            return Ok(results);
        }
    }
}
