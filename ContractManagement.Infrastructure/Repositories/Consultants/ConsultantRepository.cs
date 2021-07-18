using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Repositories.Consultants;
using ContractManagement.Infrastructure.Data;

namespace ContractManagement.Infrastructure.Repositories.Consultants
{
    public class ConsultantRepository : AbstractRepository<Consultant, DataContext>, IConsultantRepository
    {
        public ConsultantRepository(DataContext context) : base(context)
        {
        }
    }
}
