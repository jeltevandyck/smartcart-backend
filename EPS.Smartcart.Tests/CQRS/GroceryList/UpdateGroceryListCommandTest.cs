using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.DTO.GroceryList;

namespace EPS.Smartcart.Tests.CQRS.GroceryList;

[TestClass]
public class UpdateGroceryListCommandTest : AbstractCQRSHelper<UpdateGroceryListCommandHandler>
{
    [TestMethod]
    public async Task UpdateGroceryList()
    {
        var dto = new UpdateGroceryListDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Note = "Test",
            UserId = "c0a80101-0000-0000-0000-000000000001",
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new UpdateGroceryListCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual("Test", result.Note);
    }
}