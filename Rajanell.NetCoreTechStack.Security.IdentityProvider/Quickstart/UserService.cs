using IdentityServer4.Test;
using Rajanell.TechStack.Core.Repository.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Security.IdentityProvider.Quickstart
{
    public class UserService
    {
        private readonly IUserQueryRepository _queryRepository;

        public UserService(IUserQueryRepository queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task<List<TestUser>> Users()
        {
            var users = await _queryRepository.GetAll();
            var testUsers = new List<TestUser>();
            foreach(var user in users)
            {
                testUsers.Add(new TestUser { 
                    SubjectId = user.UserId.ToString(),
                    Username = user.Username,
                    Password = user.Password,
                    Claims = null
                });
            }
            return testUsers;
        }

    }
}
