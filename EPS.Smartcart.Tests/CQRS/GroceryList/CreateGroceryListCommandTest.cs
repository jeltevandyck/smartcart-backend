using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.DTO.GroceryList;

namespace EPS.Smartcart.Tests.CQRS.GroceryList;

[TestClass]
public class CreateGroceryListCommandTest : AbstractCQRSHelper<CreateGroceryListCommandHandler>
{
    [TestMethod]
    public async Task CreateGroceryList()
    {
        var dto = new CreateGroceryListDTO
        {
            Note = "Test",
            UserId = "c0a80101-0000-0000-0000-000000000001",
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new CreateGroceryListCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual("Test", result.Note);
    }
}