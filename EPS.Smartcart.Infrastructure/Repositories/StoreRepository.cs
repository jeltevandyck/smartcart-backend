using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class StoreRepository : AbstractRepository<Store>
{
    public StoreRepository(SmartcartContext context) : base(context.Stores)
    {
    }

    public override IQueryable<Store> Include(IQueryable<Store> queryable)
    {
        queryable = queryable.Include(x => x.Address).AsNoTracking();
        return queryable;
    }
}