using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.API.Store
{
    public class MessagePipelineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly HttpContext _httpContext;

        public MessagePipelineBehaviour(IHttpContextAccessor httpContextAccessor)
        {
            _httpContext = httpContextAccessor.HttpContext;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            //if (request is BaseRequest br)
            //{
            //    var clientId = _httpContext.Items["ClientId"].ToString();
            //    if (clientId != null)
            //    {
            //        if (Guid.TryParse(clientId, out var sourceSystemId))
            //            br.SourceSystemId = sourceSystemId;
            //    }
            //}

            var result = await next();
            return result;
        }
    }
}
