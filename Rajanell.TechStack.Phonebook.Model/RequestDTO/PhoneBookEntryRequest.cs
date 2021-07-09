using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Core.Model.RequestDTO
{
    public class PhoneBookEntryRequest
    {
        public Guid PhoneBookId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
