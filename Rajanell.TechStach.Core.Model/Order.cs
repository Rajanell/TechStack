using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Rajanell.TechStach.Core.Model
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; } 
        
        public virtual User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
