using Rajanell.TechStach.Core.Model.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStach.Core.Model
{
    public class ResultMessage
    {
        private readonly string _code;
        private readonly string _message;
        private ResultMessageType _messageType;
        public ResultMessage(ResultMessageType messageType, string code, string message)
        {
            _messageType = messageType;
            _code = code;
            _message = message;
        }

        public ResultMessageType MessageType => _messageType;
        public string Message => _message;
        public string Code => _code;
    }
}
