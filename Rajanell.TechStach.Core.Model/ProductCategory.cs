using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model
{
    public class ProductCategory
    {
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
