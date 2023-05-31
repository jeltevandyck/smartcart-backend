using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Validation.Order;
using EPS.Smartcart.DTO.Order;

namespace EPS.Smartcart.Tests.Validation.Order;

[TestClass]
public class DeleteOrderValidationTest : AbstractValidationTest<DeleteOrderValidation, DeleteOrderCommand>
{
    [TestMethod]
    public async Task DeleteOrderValidation()
    {
        var dto = new DeleteOrderDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };

        var command = new DeleteOrderCommand(dto);
        var result = await Validation.ValidateAsync(command);

        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteOrderValidationFalse()
    {
        var dto = new DeleteOrderDTO()
        {
            Id = ""
        };

        var command = new DeleteOrderCommand(dto);
        var result = await Validation.ValidateAsync(command);

        Assert.IsFalse(result.IsValid);
    }
}