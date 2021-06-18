using Microsoft.EntityFrameworkCore;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Query;
using Rajanell.TechStack.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.EventHandlers.Queries
{
    public class GetUserOrdersQueryEventHandler : IMessageRequestHandler<GetUserOrdersQuery, List<Order>>
    {
        private readonly StoreDBContext _context;

        public GetUserOrdersQueryEventHandler(StoreDBContext context)
        {
            _context = context;
        }

        public async Task<CommandResult<List<Order>>> Handle(GetUserOrdersQuery request, CancellationToken cancellationToken)
        {            
            var userId = Guid.Parse(request.QueryData);
            var orders = await  _context.Oders.Where(x => x.UserId == userId).Include(x=>x.OrderDetails).Include(x=> x.OrderDetails).ToListAsync();
            return new CommandResult<List<Order>>(orders, Guid.NewGuid(), true, string.Empty);
        }
    }
}
