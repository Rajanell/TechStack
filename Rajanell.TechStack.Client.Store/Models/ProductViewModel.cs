using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Client.Store.Models
{
    public class ProductViewModel
    {
        public Guid ProductId { get; set; }
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
        public Decimal TotalPrice { get; set; }
        public string Tags { get; set; }
    }
}
