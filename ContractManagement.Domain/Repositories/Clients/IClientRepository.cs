using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Specifications.Clients;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Repositories.Clients
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<List<Client>> FindAll(ClientSpecification specification);
    }
}
