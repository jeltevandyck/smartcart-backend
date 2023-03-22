using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class StoreRepository : AbstractRepository<Store>
{
    public StoreRepository(SmartcartContext context) : base(context.Stores)
    {
    }
}