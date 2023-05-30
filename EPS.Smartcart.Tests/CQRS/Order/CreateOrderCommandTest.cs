using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.DTO.Order;

namespace EPS.Smartcart.Tests.CQRS.Order;

[TestClass]
public class CreateOrderCommandTest : AbstractCQRSHelper<CreateOrderCommandHandler>
{
    [TestMethod]
    public async Task CreateOrder()
    {
        var dto = new CreateOrderDTO
        {
            CartId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new CreateOrderCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}