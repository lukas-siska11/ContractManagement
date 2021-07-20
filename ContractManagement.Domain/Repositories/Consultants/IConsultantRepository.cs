using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Specifications.Consultants;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Repositories.Consultants
{
    public interface IConsultantRepository : IRepository<Consultant>
    {
        // TODO: Move to generic repository
        Task<List<Consultant>> FindAll(ConsultantSpecification specification);

        // TODO: Move to generic repository
        Task<int> Count(ConsultantSpecification specification = null);
    }
}
