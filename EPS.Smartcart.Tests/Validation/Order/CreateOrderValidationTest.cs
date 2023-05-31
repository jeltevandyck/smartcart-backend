using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Validation.Order;
using EPS.Smartcart.DTO.Order;

namespace EPS.Smartcart.Tests.Validation.Order;

[TestClass]
public class CreateOrderValidationTest : AbstractValidationTest<CreateOrderValidation, CreateOrderCommand>
{
    [TestMethod]
    public async Task CreateOrderValidation()
    {
        var dto = new CreateOrderDTO()
        {
            CartId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new CreateOrderCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateOrderValidationFalse()
    {
        var dto = new CreateOrderDTO()
        {
            CartId = ""
        };
        
        var command = new CreateOrderCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}