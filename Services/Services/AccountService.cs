using AuthenticateAPI.Application.DTOs;
using AuthenticateAPI.Domain.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticateAPI.Services.Services
{
    public class AccountService : IAccountService
    {
        public Task<Customer> CreateAccount(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }
    }
}
