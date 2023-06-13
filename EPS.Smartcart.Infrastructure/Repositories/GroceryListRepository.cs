using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class GroceryListRepository : AbstractRepository<GroceryList>
{
    public GroceryListRepository(SmartcartContext context) : base(context.GroceryLists)
    {
    }

    public override IQueryable<GroceryList> Include(IQueryable<GroceryList> queryable)
    {
        queryable = queryable.Include(x => x.GroceryItems)
            .Include(x => x.Store).AsNoTracking();
        return queryable;
    }
}