using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Command.User;
using Rajanell.TechStack.Core.Repository.Write;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.EventHandlers.Commands
{
    public class AddUserCommandEventHandler : IMessageRequestHandler<AddUserCommand, UserResponse>
    {
        private readonly IUserCommandRepository _userRepository;
        private readonly IMapper _mapper;

        public AddUserCommandEventHandler(IUserCommandRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<UserResponse>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request.CommandData);
            user.UserId = Guid.NewGuid();
            _userRepository.Add(user);
            await _userRepository.Save();

            return new CommandResult<UserResponse>(_mapper.Map<UserResponse>(user), Guid.NewGuid(), true, string.Empty);
        }
    }
}
