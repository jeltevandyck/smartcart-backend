using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.DTO.GroceryList;

namespace EPS.Smartcart.Tests.CQRS.GroceryList;

[TestClass]
public class DeleteGroceryListCommandTest : AbstractCQRSHelper<DeleteGroceryListCommandHandler>
{
    [TestMethod]
    public async Task DeleteGroceryList()
    {
        var dto = new DeleteGroceryListDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteGroceryListCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}