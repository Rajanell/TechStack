﻿using MediatR;
using Rajanell.TechStach.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Application.Communication
{
    public interface IMessageRequest<TResponse> : IRequest<CommandResult<TResponse>> where TResponse : new()
    {

    }
}
