using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Repositories.Clients;
using ContractManagement.Domain.Specifications.Clients;
using ContractManagement.Infrastructure.Data;
using ContractManagement.Infrastructure.SpecificationEvaluators.Clients;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractManagement.Infrastructure.Repositories.Clients
{
    public class ClientRepository : AbstractRepository<Client, DataContext>, IClientRepository
    {
        public ClientRepository(DataContext context) : base(context)
        {
        }

        public async Task<int> Count(ClientSpecification specification = null)
        {
            var query = this.PrepareQuery();
            if (specification != null)
            {
                query = ClientSpecificationEvaluator.Evaluate(query, specification);
            }

            return await query.CountAsync();
        }

        public async Task<List<Client>> FindAll(ClientSpecification specification)
        {
            // TODO: Move to generic repository
            var query = ClientSpecificationEvaluator.Evaluate(this.PrepareQuery(), specification);

            return await query.Skip((specification.Page - 1) * specification.Limit)
                .Take(specification.Limit).ToListAsync();
        }
    }
}
