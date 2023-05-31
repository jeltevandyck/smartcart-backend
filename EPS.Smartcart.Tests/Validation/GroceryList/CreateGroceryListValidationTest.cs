using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Validation.GroceryList;
using EPS.Smartcart.DTO.GroceryList;

namespace EPS.Smartcart.Tests.Validation.GroceryList;

[TestClass]
public class CreateGroceryListValidationTest : AbstractValidationTest<CreateGroceryListValidation, CreateGroceryListCommand>
{
    [TestMethod]
    public async Task CreateGroceryListValidation()
    {
        var dto = new CreateGroceryListDTO()
        {
            Note = "Test note",
            UserId = "c0a80101-0000-0000-0000-000000000001",
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new CreateGroceryListCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateGroceryListValidationFalse()
    {
        var dto = new CreateGroceryListDTO()
        {
            Note = "",
            UserId = "",
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new CreateGroceryListCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}