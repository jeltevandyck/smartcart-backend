using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Validation.Product;
using EPS.Smartcart.DTO.Product;

namespace EPS.Smartcart.Tests.Validation.Product;

[TestClass]
public class CreateProductValidationTest : AbstractValidationTest<CreateProductValidation, CreateProductCommand>
{
    [TestMethod]
    public async Task CreateProductValidation()
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
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateProductValidationFalse()
    {
        var dto = new CreateProductDTO()
        {
            Name = "Test",
            Description = "",
            Price = 1,
            Discount = 0,
            DiscountPercentage = 0,
            Amount = 148,
            ExpirationDate = DateTime.Now,
            ProductionDate = DateTime.Now,
            StoreId = ""
        };
        
        var command = new CreateProductCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}