using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.DTO.OrderItem;

namespace EPS.Smartcart.Tests.CQRS.OrderItem;

[TestClass]
public class CreateOrderItemCommandTest : AbstractCQRSHelper<CreateOrderItemCommandHandler>
{
    [TestMethod]
    public async Task CreateOrderItem()
    {
        var dto = new CreateOrderItemDTO
        {
            OrderId = "c0a80101-0000-0000-0000-000000000001",
            ProductId = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1
        };
        
        var command = new CreateOrderItemCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}