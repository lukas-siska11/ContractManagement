using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Domain.Specifications.Consultants;
using ContractManagement.Infrastructure.Data;
using ContractManagement.Infrastructure.SpecificationEvaluators.Consultants;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Infrastructure.Repositories.Consultants
{
    public class ConsultantRepository : AbstractRepository<Consultant, DataContext>, IConsultantRepository
    {
        public ConsultantRepository(DataContext context) : base(context)
        {
        }

        public async Task<List<Consultant>> FindAll(ConsultantSpecification specification)
        {
            return await ConsultantSpecificationEvaluator.Evaluate(this.PrepareQuery(), specification).ToListAsync();
        }
    }
}
