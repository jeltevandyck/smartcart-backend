using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class OrderFilter : IFilter<Order>
{
    public string? Id { get; set; }
    public IQueryable<Order> Apply(IQueryable<Order> queryable)
    {
        if (Id != null) queryable = queryable.Where(x => x.Id == Id);
        return queryable;
    }
}