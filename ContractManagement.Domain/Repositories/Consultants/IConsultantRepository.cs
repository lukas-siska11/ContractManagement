using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Specifications.Consultants;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContractManagement.Domain.Repositories.Consultants
{
    public interface IConsultantRepository : IRepository<Consultant>
    {
        // TODO: Move to generic repository
        // Finds all consultants based on given specification
        Task<List<Consultant>> FindAll(ConsultantSpecification specification);

        // TODO: Move to generic repository
        // Gets count of existing consultants based on given specification
        Task<int> Count(ConsultantSpecification specification = null);
    }
}
