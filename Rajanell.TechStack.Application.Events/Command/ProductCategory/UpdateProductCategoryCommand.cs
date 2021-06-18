using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Core.Repository.Write;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Events.Command.ProductCategory
{
    public class UpdateProductCategoryCommand : ICommand<ProductCategoryUpdateRequest, ProductCategoryResponse>
    {
        public ProductCategoryUpdateRequest CommandData { get; set; }
    }
}
