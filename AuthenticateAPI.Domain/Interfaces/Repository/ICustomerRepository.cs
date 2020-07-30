using AuthenticateAPI.Domain.Class;
using System.Threading.Tasks;

namespace AuthenticateAPI.Domain.Interfaces.Repository
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        Task<Customer> CheckCredentials(string username, string password);
    }
}
