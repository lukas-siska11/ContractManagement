using ContractManagement.Domain.Entities.Contracts;
using ContractManagement.Domain.Specifications.Contracts;
using Microsoft.EntityFrameworkCore;
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
                query = query.Where(contract =>
                    contract.RegistrationNumber.Contains(specification.Search) ||
                    contract.Institution.Name.Contains(specification.Search) ||
                    contract.Client.Name.Contains(specification.Search) ||
                    contract.Client.Surname.Contains(specification.Search) ||
                    contract.Administrator.Name.Contains(specification.Search) ||
                    contract.Administrator.Surname.Contains(specification.Search)
                ); ;
            }

            if (specification.InstitutionID != null)
            {
                query = query.Where(contract => contract.Institution.ID == specification.InstitutionID);
            }

            if (specification.ClientID != null)
            {
                query = query.Where(contract => contract.Client.ID == specification.ClientID);
            }

            if (specification.AdministratorID != null)
            {
                query = query.Where(contract => contract.Administrator.ID == specification.AdministratorID);
            }

            return query;
        }
    }
}
