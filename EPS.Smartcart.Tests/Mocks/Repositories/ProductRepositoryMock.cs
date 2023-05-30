using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class ProductRepositoryMock : AbstractMockRepository<ProductFilter, Product, IRepository<Product>>
{
    public override List<Product> CreateData()
    {
        var product = new List<Product>();
        return product;
    }
}