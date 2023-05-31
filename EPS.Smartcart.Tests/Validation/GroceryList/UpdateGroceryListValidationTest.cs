using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Validation.GroceryList;
using EPS.Smartcart.DTO.GroceryList;

namespace EPS.Smartcart.Tests.Validation.GroceryList;

[TestClass]
public class UpdateGroceryListValidationTest : AbstractValidationTest<UpdateGroceryListValidation, UpdateGroceryListCommand>
{
    [TestMethod]
    public async Task UpdateGroceryListValidation()
    {
        var dto = new UpdateGroceryListDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Note = "Test",
            UserId = "c0a80101-0000-0000-0000-000000000001",
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };

        var command = new UpdateGroceryListCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }

    [TestMethod]
    public async Task UpdateGroceryListValidationFalse()
    {
        var dto = new UpdateGroceryListDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Note = "Test",
            UserId = "",
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new UpdateGroceryListCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}