using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Rajanell.TechStack.Phonebook.Core.Model;
using Rajanell.TechStack.Phonebook.Core.Repository;
using Rajanell.TechStack.Phonebook.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Phonebook.Services.Repository
{
    public class PhoneBookEntryRepository : IPhoneBookEntryRepository
    {
        private readonly PhoneBookDBContext _context;
        private readonly ILogger<PhoneBookEntryRepository> _logger;

        public PhoneBookEntryRepository(PhoneBookDBContext context, ILogger<PhoneBookEntryRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(Entry item)
        {
            _context.Add(item);
        }

        public void Add(IEnumerable<Entry> items)
        {
            _context.AddRange(items);
        }

        public async Task<IEnumerable<Entry>> Find(Expression<Func<Entry, bool>> query)
        {
            return await Task.Run(() => _context.Entries.Where(query).Include(x=>x.PhoneBook).ToListAsync());
        }

        public async Task<IEnumerable<Entry>> GetAll()
        {
            return await _context.Entries.ToListAsync();
        }

        public async Task<Entry> GetByID(Guid id)
        {
            return await _context.Entries.FindAsync(id);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Entry item)
        {
            _context.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Update(IEnumerable<Entry> items)
        {
            foreach (var item in items)
            {
                _context.Attach(item);
                _context.Entry(item).State = EntityState.Modified;
            }
        }
    }
}
