using Rajanell.TechStach.Core.Model.Common;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Events.Query.Product
{
    public class GetAllProductQuery : IQuery<ProductSearchRequest, List<ProductResponse>>
    {
        public ProductSearchRequest QueryData { get; set; }
    }
}
