using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Core.Repository.Read;
using Rajanell.TechStack.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.Repository.Read
{
    public class UserQueryRepository : IUserQueryRepository
    {
        private readonly StoreDBContext _context;

        public UserQueryRepository(StoreDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> Find(Expression<Func<User, bool>> query)
        {
            return await Task.Run(() => _context.Users.Where(query).ToListAsync());
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByID(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
