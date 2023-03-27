using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class OrderFilter : IFilter<Order>
{
    public IQueryable<Order> Apply(IQueryable<Order> queryable)
    {
        return queryable;
    }
}