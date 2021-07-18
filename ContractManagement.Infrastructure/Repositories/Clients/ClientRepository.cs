using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Specifications.Clients;
using ContractManagement.Infrastructure.Data;
using ContractManagement.Infrastructure.SpecificationEvaluators.Clients;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Infrastructure.Repositories.Clients
{
    public class ClientRepository : AbstractRepository<Client, DataContext>, IClientRepository
    {
        public ClientRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<Client>> FindAll(ClientSpecification specification)
        {
            return await ClientSpecificationEvaluator.Evaluate(this.PrepareQuery(), specification).ToListAsync();
        }
    }
}
