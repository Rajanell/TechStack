using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Events.Command.ProductCategory
{
    public class AddProductCategoryCommand : ICommand<ProductCategoryRequest, ProductCategoryResponse>
    {
        public ProductCategoryRequest CommandData { get; set; }
    }
}
