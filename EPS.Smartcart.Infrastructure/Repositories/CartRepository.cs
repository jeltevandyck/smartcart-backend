using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class CartRepository : AbstractRepository<Cart>
{
    public CartRepository(SmartcartContext context) : base(context.Carts)
    {
    }

    public override IQueryable<Cart> Include(IQueryable<Cart> queryable)
    {
        return queryable;
    }
}