using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class ProductRepositoryMock : AbstractMockRepository<ProductFilter, Product, IRepository<Product>>
{
    public override List<Product> CreateData()
    {
        var product = new List<Product>();

        product.Add(new Product
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Name = "Test",
            Description = "Test",
            Price = 1,
            Discount = 0,
            DiscountPercentage = 0,
            Amount = 148,
            ExperitionDate = DateTime.Parse("2021-12-31"),
            ProductionDate = DateTime.Parse("2021-01-01"),
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        });
        
        product.Add(new Product
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            Name = "Test",
            Description = "Test",
            Price = 1,
            Discount = 0,
            DiscountPercentage = 0,
            Amount = 148,
            ExperitionDate = DateTime.Parse("2021-12-31"),
            ProductionDate = DateTime.Parse("2021-01-01"),
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        });

        return product;
    }
}