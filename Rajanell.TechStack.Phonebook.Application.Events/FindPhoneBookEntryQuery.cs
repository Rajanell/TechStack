using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Application.Events
{
    public class FindPhoneBookEntryQuery : IQuery<string, List<PhoneBookEntryResponse>>
    {
        public string QueryData { get; set; }
    }
}
