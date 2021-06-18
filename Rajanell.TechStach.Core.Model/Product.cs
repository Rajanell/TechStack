using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        //For simplicity price is placed here 
        //Ideal: separate product pricing table with start and end date of active product price
        public Decimal Price { get; set; }
        public string Tags { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
