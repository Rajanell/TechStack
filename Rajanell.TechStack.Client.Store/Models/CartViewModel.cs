using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Client.Store.Models
{
    public class CartViewModel
    {
        public List<ProductViewModel> Products { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
