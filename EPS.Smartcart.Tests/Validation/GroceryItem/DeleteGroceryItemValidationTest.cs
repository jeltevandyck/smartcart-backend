using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.Application.Validation.GroceryItem;
using EPS.Smartcart.DTO.GroceryItem;

namespace EPS.Smartcart.Tests.Validation.GroceryItem;

[TestClass]
public class DeleteGroceryItemValidationTest : AbstractValidationTest<DeleteGroceryItemValidation, DeleteGroceryItemCommand>
{
    [TestMethod]
    public async Task DeleteGroceryItemValidation()
    {
        var dto = new DeleteGroceryItemDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteGroceryItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteGroceryItemValidationFalse()
    {
        var dto = new DeleteGroceryItemDTO()
        {
            Id = ""
        };
        
        var command = new DeleteGroceryItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}