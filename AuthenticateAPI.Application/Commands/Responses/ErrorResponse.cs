using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticateAPI.Application.Commands.Responses
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }

    public class ErrorModel
    {
        public string NameField { get; set; }
        public string Message { get; set; }

    }
}
