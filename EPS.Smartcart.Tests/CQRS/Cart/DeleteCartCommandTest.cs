using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.DTO.Cart;

namespace EPS.Smartcart.Tests.CQRS.Cart;

[TestClass]
public class DeleteCartCommandTest : AbstractCQRSHelper<DeleteCartCommandHandler>
{
    [TestMethod]
    public async Task DeleteCart()
    {
        var dto = new DeleteCartDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
        };
        
        var command = new DeleteCartCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}