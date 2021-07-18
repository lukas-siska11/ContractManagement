using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Specifications.Contracts;
using System.Linq;

namespace ContractManagement.Infrastructure.SpecificationEvaluators.Contracts
{
    public class ContractSpecificationEvaluator : AbstractSpecificationEvaluator<Contract>
    {
        public static IQueryable<Contract> Evaluate(IQueryable<Contract> query, ContractSpecification specification)
        {
            query = EvaluatePagination(query, specification);

            if (specification.Search != null)
            {
                query = query.Where(contract => contract.RegistrationNumber.Contains(specification.Search));
            }

            if (specification.InstitutionID != 0)
            {
                query = query.Where(contract => contract.Institution.ID == specification.InstitutionID);
            }

            if (specification.ClientID != 0)
            {
                query = query.Where(contract => contract.Client.ID == specification.ClientID);
            }

            if (specification.AdministratorID != 0)
            {
                query = query.Where(contract => contract.Administrator.ID == specification.AdministratorID);
            }

            return query;
        }
    }
}
