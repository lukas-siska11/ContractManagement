using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Specifications.Contracts;
using System.Linq;

namespace ContractManagement.Infrastructure.SpecificationEvaluators.Contracts
{
    public class ContractSpecificationEvaluator : AbstractSpecificationEvaluator<Contract>
    {
        public static IQueryable<Contract> Evaluate(IQueryable<Contract> query, ContractSpecification specification)
        {
            // Multiple properties are supported in contracts search
            if (specification.Search != null)
            {
                query = query.Where(contract =>
                    contract.RegistrationNumber.Contains(specification.Search) ||
                    contract.Institution.Name.Contains(specification.Search) ||
                    contract.Client.Name.Contains(specification.Search) ||
                    contract.Client.Surname.Contains(specification.Search) ||
                    contract.Administrator.Name.Contains(specification.Search) ||
                    contract.Administrator.Surname.Contains(specification.Search)
                ); ;
            }

            // Filters contracts by selected institution
            if (specification.InstitutionID != null)
            {
                query = query.Where(contract => contract.Institution.ID == specification.InstitutionID);
            }

            // Filters contracts by selected client
            if (specification.ClientID != null)
            {
                query = query.Where(contract => contract.Client.ID == specification.ClientID);
            }

            // Filters contracts by selected administrator
            if (specification.AdministratorID != null)
            {
                query = query.Where(contract => contract.Administrator.ID == specification.AdministratorID);
            }

            return query;
        }
    }
}
