using ContractManagement.Domain.Entities;
using ContractManagement.Domain.Specifications;
using System.Linq;

namespace ContractManagement.Infrastructure.SpecificationEvaluators
{
    public class AbstractSpecificationEvaluator<TEntity>
        where TEntity : class, IEntity
    {
        protected static IQueryable<TEntity> EvaluatePagination(IQueryable<TEntity> query, AbstractSpecification specification)
        {
            return query.Skip((specification.Page - 1) * specification.Limit)
                        .Take(specification.Limit);
        }
    }
}
