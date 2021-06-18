using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Application.Communication;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Events.Query
{
    public class GetUserOrdersQuery : IQuery<string, List<Order>>
    {
        public string QueryData { get; set; }
    }
}
