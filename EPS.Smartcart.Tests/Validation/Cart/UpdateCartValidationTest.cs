using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Validation.Cart;
using EPS.Smartcart.DTO.Cart;

namespace EPS.Smartcart.Tests.Validation.Cart;

[TestClass]
public class UpdateCartValidationTest : AbstractValidationTest<UpdateCartValidation, UpdateCartCommand>
{
    [TestMethod]
    public async Task UpdateCartValidation()
    {
        var dto = new UpdateCartDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            GroceryListId = "c0a80101-0000-0000-0000-000000000001",
        };
        
        var command = new UpdateCartCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task UpdateCartValidationFalse()
    {
        var dto = new UpdateCartDTO()
        {
            Id = "",
            GroceryListId = "",
        };
        
        var command = new UpdateCartCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}