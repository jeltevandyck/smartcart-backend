using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class PaginationFilter<T> : IFilter<T> where T : Entity
{
    public int Page { get; set; }
    public int PageSize { get; set; }

    public IQueryable<T> Apply(IQueryable<T> query)
    {
        if (Page < 1 || PageSize < 1) return query;
        
        return query.Skip((Page - 1) * PageSize).Take(PageSize);
    }
    
}