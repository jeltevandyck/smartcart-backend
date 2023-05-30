using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.DTO.OrderItem;

namespace EPS.Smartcart.Tests.CQRS.OrderItem;

[TestClass]
public class DeleteOrderItemCommandTest : AbstractCQRSHelper<DeleteOrderItemCommandHandler>
{
    [TestMethod]
    public async Task DeleteOrderItem()
    {
        var dto = new DeleteOrderItemDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteOrderItemCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
    
}