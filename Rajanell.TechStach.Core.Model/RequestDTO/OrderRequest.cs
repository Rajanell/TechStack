using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model.RequestDTO
{
    public class OrderRequest
    {
        public List<Guid> CartItems { get; set; }
        public string UserId { get; set; }
    }
}
