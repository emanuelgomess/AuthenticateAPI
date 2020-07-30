using System;

namespace AuthenticateAPI.Application.Commands.Responses
{
    public abstract class BaseResponse
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
