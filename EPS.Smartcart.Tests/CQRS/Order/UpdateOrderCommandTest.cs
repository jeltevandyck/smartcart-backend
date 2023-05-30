using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.DTO.Order;

namespace EPS.Smartcart.Tests.CQRS.Order;

[TestClass]
public class UpdateOrderCommandTest : AbstractCQRSHelper<UpdateOrderCommandHandler>
{
    [TestMethod]
    public async Task UpdateOrder()
    {
        var dto = new UpdateOrderDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            CartId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new UpdateOrderCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}