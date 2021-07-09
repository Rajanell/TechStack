using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Core.Model
{
    public class PhoneBook
    {
        public Guid PhoneBookId { get; set; }
        public string Name { get; set; }  
        
        public virtual List<Entry> Entries { get; set; }
    }
}
