using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.DTO.OrderItem;

namespace EPS.Smartcart.Tests.CQRS.OrderItem;

[TestClass]
public class UpdateOrderItemCommandTest : AbstractCQRSHelper<UpdateOrderItemCommandHandler>
{
    [TestMethod]
    public async Task UpdateOrderItem()
    {
        var dto = new UpdateOrderItemDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
            ProductId = "c0a80101-0000-0000-0000-000000000001",
            OrderId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new UpdateOrderItemCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}