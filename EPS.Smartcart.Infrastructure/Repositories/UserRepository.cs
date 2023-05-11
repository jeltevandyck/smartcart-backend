using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class UserRepository : AbstractRepository<User>
{
    public UserRepository(SmartcartContext context) : base(context.Users)
    {
    }
    
    public override IQueryable<User> Include(IQueryable<User> queryable)
    {
        queryable = queryable.Include(x => x.Orders)
            .Include(x => x.GroceryLists).AsNoTracking();
        return queryable;
    }
}