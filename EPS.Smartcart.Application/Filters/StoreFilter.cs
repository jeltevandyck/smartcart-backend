using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class StoreFilter : IFilter<Store>
{
    public string? Id { get; set; }
    public IQueryable<Store> Apply(IQueryable<Store> queryable)
    {
        if (Id != null) queryable = queryable.Where(x => x.Id == Id);

        return queryable;
    }
}