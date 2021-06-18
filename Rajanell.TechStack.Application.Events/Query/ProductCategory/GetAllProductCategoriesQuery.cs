using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Events.Query.ProductCategory
{
    public class GetAllProductCategoriesQuery : IQuery<object, List<ProductCategoryResponse>>
    {
        public object QueryData { get; set; }
    }
}
