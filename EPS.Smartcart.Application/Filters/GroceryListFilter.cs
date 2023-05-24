using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class GroceryListFilter : IFilter<GroceryList>
{
    public IQueryable<GroceryList> Apply(IQueryable<GroceryList> queryable)
    {
        return queryable;
    }
}