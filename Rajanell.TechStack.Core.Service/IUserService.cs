using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Core.Service
{
    public interface IUserService
    {
        Task<bool> IsUsernameUnique(string username);
    }
}
