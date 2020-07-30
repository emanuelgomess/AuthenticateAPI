using AuthenticateAPI.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticateAPI.Application.Commands.Queries
{
    public class GetAllCustomerQuery : IRequest<List<CustomerDTO>>
    {

    }
}
