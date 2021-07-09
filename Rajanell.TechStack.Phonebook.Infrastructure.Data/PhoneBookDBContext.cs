using Microsoft.EntityFrameworkCore;
using Rajanell.TechStack.Phonebook.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Infrastructure.Data
{
    public class PhoneBookDBContext : DbContext
    {
        public PhoneBookDBContext(DbContextOptions<PhoneBookDBContext> dbco) : base(dbco) { }

        public DbSet<PhoneBook> PhoneBooks { get; set; }
        public DbSet<Entry> Entries { get; set; }
    }
}
