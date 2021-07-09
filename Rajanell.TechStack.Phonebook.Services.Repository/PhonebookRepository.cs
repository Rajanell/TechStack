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
    public class PhonebookRepository : IPhoneBookRepository
    {
        private readonly PhoneBookDBContext _context;
        private readonly ILogger<PhonebookRepository> _logger;

        public PhonebookRepository(PhoneBookDBContext context, ILogger<PhonebookRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void Add(PhoneBook item)
        {
            _context.Add(item);
        }

        public void Add(IEnumerable<PhoneBook> items)
        {
            _context.AddRange(items);
        }

        public async Task<IEnumerable<PhoneBook>> Find(Expression<Func<PhoneBook, bool>> query)
        {
            return await Task.Run(() => _context.PhoneBooks.Where(query).Include(x=>x.Entries).ToListAsync());
        }

        public async Task<IEnumerable<PhoneBook>> GetAll()
        {
            return await _context.PhoneBooks.Include(x=>x.Entries).ToListAsync();
        }

        public async Task<PhoneBook> GetByID(Guid id)
        {
            return  _context.PhoneBooks.Where(x=> x.PhoneBookId == id).Include(x=>x.Entries).FirstOrDefault();
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(PhoneBook item)
        {
            _context.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Update(IEnumerable<PhoneBook> items)
        {
            foreach (var item in items)
            {
                _context.Attach(item);
                _context.Entry(item).State = EntityState.Modified;
            }
        }
    }
}
