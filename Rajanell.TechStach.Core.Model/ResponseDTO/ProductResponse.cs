using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model.ResponseDTO
{
    public class ProductResponse
    {
        public Guid ProductId { get; set; }
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Decimal Price { get; set; }
        public string Tags { get; set; }        
    }
}
