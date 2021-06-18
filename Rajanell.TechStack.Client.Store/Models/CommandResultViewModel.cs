using Rajanell.TechStach.Core.Model.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Client.Store.Models
{
    public class CommandResultViewModel<T>
    {
        public bool accepted { get; set; }
        public Guid? ResourceId { get; set; }
        public string ResourceUrl { get; set; }
        public T Resource { get; set; }

        private readonly List<ResultMessageViewModel> _messages;
    }
    public class ResultMessageViewModel
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public ResultMessageType MessageType { get; set; }
    }
}
