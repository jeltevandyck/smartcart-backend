using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.DTO.Product;

namespace EPS.Smartcart.Tests.CQRS.Product;

[TestClass]
public class UpdateProductCommandTest : AbstractCQRSHelper<UpdateProductCommandHandler>
{
    [TestMethod]
    public async Task UpdateProduct()
    {
        var dto = new UpdateProductDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Name = "Test",
            Description = "Test",
            Price = 1,
            Discount = 0,
            DiscountPercentage = 0,
            Amount = 148,
            ExperitionDate = DateTime.Now,
            ProductionDate = DateTime.Now,
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };

        var command = new UpdateProductCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}