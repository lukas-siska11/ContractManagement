using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Specifications.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Repositories.Contracts
{
    public interface IContractRepository : IRepository<Contract>
    {
        Task<List<Contract>> FindAll(ContractSpecification specification);
    }
}
