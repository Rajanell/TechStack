using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model.RequestDTO
{
    public class ProductSearchRequest : ResourceParameters
    {
        public string Search { get; set; }
    }
}
