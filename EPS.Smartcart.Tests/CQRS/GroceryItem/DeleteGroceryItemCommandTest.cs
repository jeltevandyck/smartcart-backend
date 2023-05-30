using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.DTO.GroceryItem;

namespace EPS.Smartcart.Tests.CQRS.GroceryItem;

[TestClass]
public class DeleteGroceryItemCommandTest : AbstractCQRSHelper<DeleteGroceryItemCommandHandler>
{
    [TestMethod]
    public async Task DeleteGroceryItem()
    {
        var dto = new DeleteGroceryItemDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
        };
        
        var command = new DeleteGroceryItemCommand(dto);
        
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
    
}