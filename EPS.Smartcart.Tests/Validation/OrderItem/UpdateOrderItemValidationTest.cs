using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.Application.Validation.OrderItem;
using EPS.Smartcart.DTO.OrderItem;

namespace EPS.Smartcart.Tests.Validation.OrderItem;

[TestClass]
public class UpdateOrderItemValidationTest : AbstractValidationTest<UpdateOrderItemValidation, UpdateOrderItemCommand>
{
    [TestMethod]
    public async Task UpdateOrderItemValidation()
    {
        var dto = new UpdateOrderItemDTO()
        {
            Id ="c0a80101-0000-0000-0000-000000000001",
            OrderId = "c0a80101-0000-0000-0000-000000000001",
            ProductId = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1
        };
        
        var command = new UpdateOrderItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }

    [TestMethod]
    public async Task UpdateOrderItemValidationFalse()
    {
        var dto = new UpdateOrderItemDTO()
        {
            Id ="c0a80101-0000-0000-0000-000000000001",
            OrderId = "",
            ProductId = "",
            Amount = 0
        };
        
        var command = new UpdateOrderItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}