using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Application.Communication
{
    public class MessageService : IMessageService
    {
        private readonly IMediator mediator;

        public MessageService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            return mediator.Send(request);
        }
    }
}
