using Rajanell.TechStack.Core.Repository.Read;
using Rajanell.TechStack.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services
{
    public class UserService : IUserService
    {
        private readonly IUserQueryRepository _userRepository;

        public UserService(IUserQueryRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> IsUsernameUnique(string username)
        {
            var users = await _userRepository.Find(x => x.Username == username);
            return !username.Any();
        }
    }
}
