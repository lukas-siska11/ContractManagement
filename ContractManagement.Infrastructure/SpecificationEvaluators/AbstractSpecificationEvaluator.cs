using ContractManagement.Domain.Entities;

namespace ContractManagement.Infrastructure.SpecificationEvaluators
{
    // Evaluates given specification
    public class AbstractSpecificationEvaluator<TEntity>
        where TEntity : class, IEntity
    {
    }
}
