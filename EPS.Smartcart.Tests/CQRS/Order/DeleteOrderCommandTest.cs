using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.DTO.Order;

namespace EPS.Smartcart.Tests.CQRS.Order;

[TestClass]
public class DeleteOrderCommandTest : AbstractCQRSHelper<DeleteOrderCommandHandler>
{
    [TestMethod]
    public async Task DeleteOrder()
    {
        var dto = new DeleteOrderDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteOrderCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}