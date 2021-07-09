using Rajanell.TechStack.Core.Repository;
using Rajanell.TechStack.Phonebook.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Core.Repository
{
    public interface IPhoneBookRepository : ICommandRepository<PhoneBook>, IQueryRepository<PhoneBook>
    {
    }
}
