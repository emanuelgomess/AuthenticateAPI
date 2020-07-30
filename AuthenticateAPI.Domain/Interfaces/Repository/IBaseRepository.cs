using AuthenticateAPI.Domain.Class;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticateAPI.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : Entity
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<int> Add(T entity);
        Task<int> Delete(int id);
        Task<int> Update(T entity);
    }
}
