using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class OrderItemRepository : AbstractRepository<OrderItem>
{
    public OrderItemRepository(DbSet<OrderItem> data) : base(data)
    {
    }

    public override IQueryable<OrderItem> Include(IQueryable<OrderItem> queryable)
    {
        return queryable;
    }
}