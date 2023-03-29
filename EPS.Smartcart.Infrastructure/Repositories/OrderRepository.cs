using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class OrderRepository : AbstractRepository<Order>
{
    public OrderRepository(SmartcartContext context) : base(context.Orders)
    {
    }

    public override IQueryable<Order> Include(IQueryable<Order> queryable)
    {
        return queryable;
    }
}