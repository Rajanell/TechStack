using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Application.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Events.Command.Order
{
    public class PlaceOrderCommand : ICommand<OrderRequest, Guid>
    {
        public OrderRequest CommandData { get; set; }
    }
}
