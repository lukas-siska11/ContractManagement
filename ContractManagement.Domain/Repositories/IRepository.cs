using ContractManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> FindAll();
        Task<T> FindById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
