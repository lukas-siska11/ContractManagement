using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Domain.Specifications.Consultants;
using ContractManagement.Infrastructure.Data;
using ContractManagement.Infrastructure.SpecificationEvaluators.Consultants;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractManagement.Infrastructure.Repositories.Consultants
{
    public class ConsultantRepository : AbstractRepository<Consultant, DataContext>, IConsultantRepository
    {
        public ConsultantRepository(DataContext context) : base(context)
        {
        }

        public async Task<int> Count(ConsultantSpecification specification = null)
        {
            var query = this.PrepareQuery();
            if (specification != null)
            {
                query = ConsultantSpecificationEvaluator.Evaluate(query, specification);
            }

            return await query.CountAsync();
        }

        public async Task<List<Consultant>> FindAll(ConsultantSpecification specification)
        {
            // TODO: Move to generic repository
            var query = ConsultantSpecificationEvaluator.Evaluate(this.PrepareQuery(), specification);

            return await query.Skip((specification.Page - 1) * specification.Limit)
                .Take(specification.Limit).ToListAsync();
        }
    }
}
