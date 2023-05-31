using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.Application.Validation.Order;
using EPS.Smartcart.Application.Validation.OrderItem;
using EPS.Smartcart.DTO.OrderItem;

namespace EPS.Smartcart.Tests.Validation.OrderItem;

[TestClass]
public class CreateOrderItemValidationTest : AbstractValidationTest<CreateOrderItemValidation, CreateOrderItemCommand>
{
    [TestMethod]
    public async Task CreateOrderItemValidation()
    {
        var dto = new CreateOrderItemDTO()
        {
            OrderId = "c0a80101-0000-0000-0000-000000000001",
            ProductId = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1
        };
        
        var command = new CreateOrderItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateOrderItemValidationFalse()
    {
        var dto = new CreateOrderItemDTO()
        {
            OrderId = "",
            ProductId = "",
            Amount = 0
        };
        
        var command = new CreateOrderItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}