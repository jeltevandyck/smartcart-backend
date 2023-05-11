using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class GroceryItemRepository : AbstractRepository<GroceryItem>
{
    public GroceryItemRepository(SmartcartContext context) : base(context.GroceryItems)
    {
    }

    public override IQueryable<GroceryItem> Include(IQueryable<GroceryItem> queryable)
    {
        return queryable;
    }
}