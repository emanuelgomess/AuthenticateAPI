using AuthenticateAPI.Application.Commands.Responses;
using AuthenticateAPI.Domain.Class;
using MediatR;

namespace AuthenticateAPI.Application.Commands.Requests
{
    public class CreateCustomerCommand : IRequest<Response>
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
    }
}
