using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Validation.Product;
using EPS.Smartcart.DTO.Product;

namespace EPS.Smartcart.Tests.Validation.Product;

[TestClass]
public class UpdateProductValidationTest : AbstractValidationTest<UpdateProductValidation, UpdateProductCommand>
{
    [TestMethod]
    public async Task UpdateProductValidation()
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
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task UpdateProductValidationFalse()
    {
        var dto = new UpdateProductDTO()
        {
            Id = "",
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
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}