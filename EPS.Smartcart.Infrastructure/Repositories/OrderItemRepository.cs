using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class OrderItemRepository : AbstractRepository<OrderItem>
{
    public OrderItemRepository(SmartcartContext context) : base(context.OrderItems)
    {
    }

    public override IQueryable<OrderItem> Include(IQueryable<OrderItem> queryable)
    {
        queryable = queryable.Include(x => x.Product).AsNoTracking();
        return queryable;
    }
}