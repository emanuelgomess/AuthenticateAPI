using AuthenticateAPI.Domain.Helpers;
using System;

namespace AuthenticateAPI.Application.Commands.Responses
{
    public class ResponseCreateCustomer : BaseResponse
    {
        public Guid UserId { get; set; }

        public ResponseCreateCustomer(string message, int statusCode, bool success)
        {
            this.Message = message;
            this.StatusCode = statusCode;
            this.Success = success;
            this.Timestamp = DateTimeHelper.GetBrazilianDateTime();
        }
    }
}
