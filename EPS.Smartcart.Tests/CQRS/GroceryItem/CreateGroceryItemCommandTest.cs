using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.DTO.GroceryItem;

namespace EPS.Smartcart.Tests.CQRS.GroceryItem;

[TestClass]
public class CreateGroceryItemCommandTest : AbstractCQRSHelper<CreateGroceryItemCommandHandler>
{
    [TestMethod]
    public async Task CreateGroceryItem()
    {
        var dto = new CreateGroceryItemDTO
        {
            GroceryListId = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
            ProductId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new CreateGroceryItemCommand(dto);
        
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}