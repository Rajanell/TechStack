using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Communication
{
    public interface IQuery<TRequest, TResponse> : IMessageRequest<TResponse> where TResponse : new()
    {
        TRequest QueryData { get; set; }
    }
}
