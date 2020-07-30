using AuthenticateAPI.Application.DTOs;
using AuthenticateAPI.Domain.Class;
using System.Threading.Tasks;

namespace AuthenticateAPI.Services.Services
{
    public interface IAccountService
    {
        Task<Customer> CreateAccount(CustomerDTO customer);
    }
}
