using Microsoft.EntityFrameworkCore;
using Rajanell.TechStack.Core.Repository;
using Rajanell.TechStack.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly StoreDBContext _context;
        private readonly DbSet<T> entity = null;

        public GenericRepository(StoreDBContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }
        public void Add(T item)
        {
            _context.Add(item);
        }

        public void Add(IEnumerable<T> items)
        {
            _context.AddRange(items);
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> query)
        {
            return await Task.Run(() => entity.Where(query));
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await entity.ToListAsync();
        }

        public async Task<T> GetByID(Guid id)
        {
            return await entity.FindAsync(id);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T item)
        {
            entity.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Update(IEnumerable<T> items)
        {
            foreach(var item in items)
            {
                entity.Attach(item);
                _context.Entry(item).State = EntityState.Modified;
            }
        }
    }
}
