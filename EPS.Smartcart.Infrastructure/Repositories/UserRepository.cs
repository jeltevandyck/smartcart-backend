using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class UserRepository : AbstractRepository<User>
{
    public UserRepository(SmartcartContext context) : base(context.Users)
    {
    }
}