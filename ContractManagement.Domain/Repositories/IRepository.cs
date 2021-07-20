using ContractManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Repositories
{
    // Defines generic methods in repositories
    public interface IRepository<T> where T : class, IEntity
    {
        // Find all entities
        Task<List<T>> FindAll();

        // Find entity by its id
        Task<T> FindById(int id);

        // Create entity with provided values
        Task<T> Create(T entity);

        // Update entity with provided values
        Task<T> Update(T entity);

        // Delete entity by its id
        Task<T> Delete(int id);
    }
}
