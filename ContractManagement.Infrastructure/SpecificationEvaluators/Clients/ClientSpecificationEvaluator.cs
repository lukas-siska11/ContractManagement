using ContractManagement.Domain.Entities.Clients;
using ContractManagement.Domain.Specifications.Clients;
using System.Linq;

namespace ContractManagement.Infrastructure.SpecificationEvaluators.Clients
{
    public class ClientSpecificationEvaluator : AbstractSpecificationEvaluator<Client>
    {
        public static IQueryable<Client> Evaluate(IQueryable<Client> query, ClientSpecification specification)
        {
            // Multiple properties are supported in client search
            if (specification.Search != null)
            {
                query = query.Where(client =>
                    client.Name.Contains(specification.Search) ||
                    client.Surname.Contains(specification.Search)
                );
            }

            return query;
        }
    }
}
