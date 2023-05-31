using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Validation.GroceryList;
using EPS.Smartcart.DTO.GroceryList;

namespace EPS.Smartcart.Tests.Validation.GroceryList;

[TestClass]
public class DeleteGroceryListValidationTest : AbstractValidationTest<DeleteGroceryListValidation, DeleteGroceryListCommand>
{
    [TestMethod]
    public async Task DeleteGroceryListValidation()
    {
        var dto = new DeleteGroceryListDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteGroceryListCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteGroceryListValidationFalse()
    {
        var dto = new DeleteGroceryListDTO()
        {
            Id = ""
        };
        
        var command = new DeleteGroceryListCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}