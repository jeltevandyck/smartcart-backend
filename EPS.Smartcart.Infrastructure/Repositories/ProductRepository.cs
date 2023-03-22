using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public class ProductRepository : AbstractRepository<Product>
{
    public ProductRepository(SmartcartContext context) : base(context.Products)
    {
    }
}