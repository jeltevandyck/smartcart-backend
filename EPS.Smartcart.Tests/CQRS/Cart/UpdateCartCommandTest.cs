using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.DTO.Cart;

namespace EPS.Smartcart.Tests.CQRS.Cart;

[TestClass]
public class UpdateCartCommandTest : AbstractCQRSHelper<UpdateCartCommandHandler>
{
    [TestMethod]
    public async Task UpdateCart()
    {
        var dto = new UpdateCartDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            GroceryListId = "c0a80101-0000-0000-0000-000000000001",
        };
        
        var command = new UpdateCartCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
    
}