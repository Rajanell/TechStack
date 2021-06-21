using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Validation
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
        public ErrorResponse() { }
        public ErrorResponse(ErrorModel error)
        {
            Errors.Add(error);
        }
    }
    public class ErrorModel
    {
        public string FieldName { get; set; }
        public string Message { get; set; }
    }
}
