using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Core.Repository.Write;
using Rajanell.TechStack.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.Repository.Write
{
    public class UserCommandRepository : IUserCommandRepository
    {
        private readonly StoreDBContext _context;
        private readonly ILogger<UserCommandRepository> _logger;

        public UserCommandRepository(StoreDBContext context, ILogger<UserCommandRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(User item)
        {
            _context.Add(item);
        }

        public void Add(IEnumerable<User> items)
        {
            _context.AddRange(items);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(User item)
        {
            _context.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Update(IEnumerable<User> items)
        {
            foreach (var item in items)
            {
                _context.Attach(item);
                _context.Entry(item).State = EntityState.Modified;
            }
        }
    }
}
