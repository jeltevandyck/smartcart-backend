using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Validation.Order;
using EPS.Smartcart.DTO.Order;

namespace EPS.Smartcart.Tests.Validation.Order;

[TestClass]
public class UpdateOrderValidationTest : AbstractValidationTest<UpdateOrderValidation, UpdateOrderCommand>
{
    [TestMethod]
    public async Task UpdateOrderValidation()
    {
        var dto = new UpdateOrderDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            CartId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new UpdateOrderCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task UpdateOrderValidationFalse()
    {
        var dto = new UpdateOrderDTO()
        {
            Id = "",
            CartId = ""
        };
        
        var command = new UpdateOrderCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}