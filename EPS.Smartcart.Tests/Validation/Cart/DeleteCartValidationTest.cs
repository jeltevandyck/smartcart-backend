using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Validation.Cart;
using EPS.Smartcart.DTO.Cart;

namespace EPS.Smartcart.Tests.Validation.Cart;

[TestClass]
public class DeleteCartValidationTest : AbstractValidationTest<DeleteCartValidation, DeleteCartCommand>
{
    [TestMethod]
    public async Task DeleteCartValidation()
    {
        var dto = new DeleteCartDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteCartCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteCartValidationFalse()
    {
        var dto = new DeleteCartDTO
        {
            Id = ""
        };
        
        var command = new DeleteCartCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}