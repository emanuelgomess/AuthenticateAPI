using AuthenticateAPI.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticateAPI.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
    }
}
