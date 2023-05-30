using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.DTO.GroceryItem;

namespace EPS.Smartcart.Tests.CQRS.GroceryItem;

[TestClass]
public class UpdateGroceryItemCommandTest : AbstractCQRSHelper<UpdateGroceryItemCommandHandler>
{
    [TestMethod]
    public async Task UpdateGroceryItem()
    {
        var dto = new UpdateGroceryItemDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
        };
        
        var command = new UpdateGroceryItemCommand(dto);
        
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}