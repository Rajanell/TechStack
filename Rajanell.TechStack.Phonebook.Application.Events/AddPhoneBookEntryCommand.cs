using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Phonebook.Core.Model.RequestDTO;
using Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Application.Events
{
    public class AddPhoneBookEntryCommand : ICommand<PhoneBookEntryRequest, PhoneBookEntryResponse>
    {
        public PhoneBookEntryRequest CommandData { get; set; }
    }
}
