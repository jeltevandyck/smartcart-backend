using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.Application.Validation.OrderItem;
using EPS.Smartcart.DTO.OrderItem;

namespace EPS.Smartcart.Tests.Validation.OrderItem;

[TestClass]
public class DeleteOrderItemValidationTest : AbstractValidationTest<DeleteOrderItemValidation, DeleteOrderItemCommand>
{
    [TestMethod]
    public async Task DeleteOrderItemValidation()
    {
        var dto = new DeleteOrderItemDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteOrderItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteOrderItemValidationFalse()
    {
        var dto = new DeleteOrderItemDTO()
        {
            Id = ""
        };
        
        var command = new DeleteOrderItemCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}