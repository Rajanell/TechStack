using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model.ResponseDTO
{
    public class ProductCategoryResponse
    {
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
