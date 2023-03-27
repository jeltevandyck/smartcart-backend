using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class OrderRepository : AbstractRepository<Order>
{
    public OrderRepository(DbSet<Order> data) : base(data)
    {
    }

    public override IQueryable<Order> Include(IQueryable<Order> queryable)
    {
        return queryable;
    }
}