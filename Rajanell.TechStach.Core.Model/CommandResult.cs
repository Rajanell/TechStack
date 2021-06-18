using Rajanell.TechStach.Core.Model.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model
{
    public class CommandResult
    {
        public bool Accepted { get; }
        public Guid? ResourceId { get; }
        public string ResourceUrl { get; }

        private readonly List<ResultMessage> _messages;
        public CommandResult(Guid resourceId, bool accepted)
        {
            ResourceId = resourceId;
            Accepted = accepted;
            _messages = new List<ResultMessage>();
        }
        public CommandResult(Guid resourceId, bool accepted, string url)
        {
            ResourceId = resourceId;
            Accepted = accepted;
            ResourceUrl = url;
            _messages = new List<ResultMessage>();
        }

        public IEnumerable<ResultMessage> Messages => _messages;

        public void AddResultMessage(ResultMessageType messageType, string code, string message)
        {
            _messages.Add(new ResultMessage(messageType, code, message));
        }

    }
    public class CommandResult<T> : CommandResult where T : new()

    {
        public T Resource { get; }

        public CommandResult(T resource, Guid resourceId, bool accepted, string url) : base(resourceId, accepted, url)
        {
            Resource = resource;
        }
    }
}
