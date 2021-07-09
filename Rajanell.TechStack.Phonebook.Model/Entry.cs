using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Core.Model
{
    public class Entry
    {
        public Guid EntryId { get; set; }
        public Guid PhoneBookId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public virtual PhoneBook PhoneBook  { get;set;}
    }
}
