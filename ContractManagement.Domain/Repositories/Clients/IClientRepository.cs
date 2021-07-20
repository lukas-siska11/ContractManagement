using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Specifications.Clients;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Repositories.Clients
{
    public interface IClientRepository : IRepository<Client>
    {
        // TODO: Move to generic repository
        // Finds all clients based on given specification
        Task<List<Client>> FindAll(ClientSpecification specification);

        // TODO: Move to generic repository
        // Gets count of existing clients based on given specification
        Task<int> Count(ClientSpecification specification = null);
    }
}
