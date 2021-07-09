using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO
{
    public class PhoneBookResponse
    {
        public Guid PhoneBookId { get; set; }
        public string Name { get; set; }
        public List<PhoneBookEntryResponse> Entries { get; set; }
    }
}
