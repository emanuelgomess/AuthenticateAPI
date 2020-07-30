using AuthenticateAPI.Domain.Interfaces.Repository;
using AuthenticateAPI.Domain.Interfaces.UnitOfWork;

namespace AuthenticateAPI.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        public ICustomerRepository CustomerRepository { get; }
    }
}
