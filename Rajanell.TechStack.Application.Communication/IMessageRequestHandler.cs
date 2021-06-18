using MediatR;
using Rajanell.TechStach.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Communication
{
    public interface IMessageRequestHandler<TCommand, TResponse> : IRequestHandler<TCommand, CommandResult<TResponse>> where TResponse : new()
    where TCommand : IMessageRequest<TResponse>
    { }
}
