using ContractManagement.Domain.Entities.Consultants;
using ContractManagement.Domain.Specifications.Consultants;
using System.Linq;

namespace ContractManagement.Infrastructure.SpecificationEvaluators.Consultants
{
    public class ConsultantSpecificationEvaluator : AbstractSpecificationEvaluator<Consultant>
    {
        public static IQueryable<Consultant> Evaluate(IQueryable<Consultant> query, ConsultantSpecification specification)
        {
            if (specification.Search != null)
            {
                query = query.Where(consultant =>
                    consultant.Name.Contains(specification.Search) ||
                    consultant.Surname.Contains(specification.Search)
                );
            }

            return query;
        }
    }
}
