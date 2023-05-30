using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.DTO.Product;

namespace EPS.Smartcart.Tests.CQRS.Product;

[TestClass]
public class CreateProductCommandTest : AbstractCQRSHelper<CreateProductCommandHandler>
{
    [TestMethod]
    public async Task CreateProduct()
    {
        var dto = new CreateProductDTO()
        {
            Name = "Test",
            Description = "Test",
            Price = 1,
            Discount = 0,
            DiscountPercentage = 0,
            Amount = 148,
            ExpirationDate = DateTime.Now,
            ProductionDate = DateTime.Now,
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };

        var command = new CreateProductCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}