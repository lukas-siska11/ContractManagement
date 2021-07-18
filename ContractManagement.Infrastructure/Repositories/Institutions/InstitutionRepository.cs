using ContractManagement.Domain.Entities.Institutions;
using ContractManagement.Domain.Repositories.Institutions;
using ContractManagement.Infrastructure.Data;

namespace ContractManagement.Infrastructure.Repositories.Institutions
{
    public class InstitutionRepository : AbstractRepository<Institution, DataContext>, IInstitutionRepository
    {
        public InstitutionRepository(DataContext context) : base(context)
        {
        }
    }
}
