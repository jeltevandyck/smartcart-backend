using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class AddressRepository : AbstractRepository<Address>
{
    public AddressRepository(SmartcartContext context) : base(context.Addresses)
    {
    }
    
    public override IQueryable<Address> Include(IQueryable<Address> queryable)
    {
        return queryable;
    }
}