using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Repositories.Contracts;
using ContractManagement.Domain.Specifications.Contracts;
using ContractManagement.Infrastructure.Data;
using ContractManagement.Infrastructure.SpecificationEvaluators.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContractManagement.Infrastructure.Repositories.Contracts
{
    public class ContractRepository : AbstractRepository<Contract, DataContext>, IContractRepository
    {
        public ContractRepository(DataContext context) : base(context)
        {
        }

        protected override IQueryable<Contract> PrepareQuery()
        {
            return this.context.Set<Contract>()
                .Include(contract => contract.Institution)
                .Include(contract => contract.Client)
                .Include(contract => contract.Administrator)
                .Include(contract => contract.Consultants);
        }

        public async Task<List<Contract>> FindAll(ContractSpecification specification)
        {
            return await ContractSpecificationEvaluator.Evaluate(this.PrepareQuery(), specification).ToListAsync();
        }
    }
}
