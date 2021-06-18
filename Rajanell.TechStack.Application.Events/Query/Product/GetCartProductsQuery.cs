using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Events.Query.Product
{
    public class GetCartProductsQuery : IQuery<string, List<ProductResponse>>
    {
        public string QueryData { get; set; }
    }
}
