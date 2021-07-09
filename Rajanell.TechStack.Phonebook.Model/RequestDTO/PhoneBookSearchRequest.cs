using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Core.Model.RequestDTO
{
    public class PhoneBookSearchRequest
    {
        public Guid PhoneBookId { get; set; }
        public string SearchString { get; set; }
    }
}
