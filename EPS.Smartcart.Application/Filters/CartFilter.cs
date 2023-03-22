using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class CartFilter : IFilter<Cart>
{
    public string? Id { get; set; }
    public IQueryable<Cart> Apply(IQueryable<Cart> queryable)
    {
        if (Id != null) queryable = queryable.Where(x => x.Id == Id);

        return queryable;
    }
}