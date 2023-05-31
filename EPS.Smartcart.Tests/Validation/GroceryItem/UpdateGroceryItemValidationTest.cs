using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.Application.Validation.GroceryItem;
using EPS.Smartcart.DTO.GroceryItem;

namespace EPS.Smartcart.Tests.Validation.GroceryItem;

[TestClass]
public class UpdateGroceryItemValidationTest : AbstractValidationTest<UpdateGroceryItemValidation, UpdateGroceryItemCommand>
{
    [TestMethod]
    public async Task UpdateGroceryItemValidation()
    {
        var dto = new UpdateGroceryItemDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
            IsCollected = true
        };
        
        var command = new UpdateGroceryItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task UpdateGroceryItemValidationFalse()
    {
        var dto = new UpdateGroceryItemDTO()
        {
            Id = "",
            Amount = 1,
            IsCollected = true
        };
        
        var command = new UpdateGroceryItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
    
}