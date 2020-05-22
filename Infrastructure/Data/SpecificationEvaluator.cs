using System.Linq;
using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    /// Input an IQueryable<T> object and ISpecification<T> object spec, return an new IQueryable<T>
    /// which contains the criteria and includes in the specification;
    /// Name is more like QueryBuilder
    public class SpecificationEvaluator<T> where T : BaseEntity // Only BaseEntity objects can be evaluated
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
        {
            var query = inputQuery;

            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}