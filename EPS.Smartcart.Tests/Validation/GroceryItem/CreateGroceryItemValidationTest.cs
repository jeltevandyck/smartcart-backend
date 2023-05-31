using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.Application.Validation.GroceryItem;
using EPS.Smartcart.DTO.GroceryItem;

namespace EPS.Smartcart.Tests.Validation.GroceryItem;

[TestClass]
public class CreateGroceryItemValidationTest : AbstractValidationTest<CreateGroceryItemValidation, CreateGroceryItemCommand>
{
    [TestMethod]
    public async Task CreateGroceryItem()
    {
        var dto = new CreateGroceryItemDTO()
        {
            GroceryListId = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
            ProductId = "c0a80101-0000-0000-0000-000000000001"
            
        };

        var command = new CreateGroceryItemCommand(dto);
        var result = await Validation.ValidateAsync(command);

        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateGroceryItemFalse()
    {
        var dto = new CreateGroceryItemDTO()
        {
            GroceryListId = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
            ProductId = ""
            
        };

        var command = new CreateGroceryItemCommand(dto);
        var result = await Validation.ValidateAsync(command);

        Assert.IsFalse(result.IsValid);
    }
}