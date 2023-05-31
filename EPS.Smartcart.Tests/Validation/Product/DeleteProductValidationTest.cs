using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Validation.Product;
using EPS.Smartcart.DTO.Product;

namespace EPS.Smartcart.Tests.Validation.Product;

[TestClass]
public class DeleteProductValidationTest : AbstractValidationTest<DeleteProductValidation, DeleteProductCommand>
{
    [TestMethod]
    public async Task DeleteProductValidation()
    {
        var dto = new DeleteProductDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteProductCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteProductValidationFalse()
    {
        var dto = new DeleteProductDTO()
        {
            Id = ""
        };
        
        var command = new DeleteProductCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}