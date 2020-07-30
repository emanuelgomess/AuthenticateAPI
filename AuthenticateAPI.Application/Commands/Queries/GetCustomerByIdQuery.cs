using AuthenticateAPI.Application.DTOs;
using MediatR;

namespace AuthenticateAPI.Application.Commands.Queries
{
    public class GetCustomerByIdQuery : IRequest<CustomerDTO>
    {
        public int Id { get; set; }
    }
}
