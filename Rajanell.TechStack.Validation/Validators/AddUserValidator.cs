using FluentValidation;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStack.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Validation.Validators
{
    public class AddUserValidator : AbstractValidator<UserRequest>
    {
        private readonly IUserService _userService;
        public AddUserValidator(IUserService userService)
        {
            _userService = userService;

            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Username).NotEmpty().EmailAddress().WithMessage("Username not a valid email address");
            RuleFor(x => x.Username).MustAsync(async (a, c) => await IsUsernameUnique(a)).WithMessage("Username/Email address already registered");
        }
        public async Task<bool> IsUsernameUnique(string username)
        {
            return await _userService.IsUsernameUnique(username);
        }
    }
}
