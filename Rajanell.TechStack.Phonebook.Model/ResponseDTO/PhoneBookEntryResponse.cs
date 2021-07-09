using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO
{
    public class PhoneBookEntryResponse
    {
        public Guid EntryId { get; set; }
        public Guid PhoneBookId { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }

        public PhoneBook PhoneBook { get; set; }
    }
}
