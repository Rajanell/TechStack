using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Validation
{
    public static class ErrorResults
    {
        public static CommandResult InvalidResult(string error)
        {
            var result = new CommandResult(Guid.NewGuid(), false);
            result.AddResultMessage(ResultMessageType.Error, "", error);
            return result;
        }
        public static CommandResult InvalidResult(string error, ResultMessageType resultMessageType)
        {
            var result = new CommandResult(Guid.NewGuid(), false);
            result.AddResultMessage(resultMessageType, "", error);
            return result;
        }
    }
}
