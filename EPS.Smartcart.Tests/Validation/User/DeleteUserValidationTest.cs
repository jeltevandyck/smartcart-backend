using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.Application.Validation.User;
using EPS.Smartcart.DTO.User;

namespace EPS.Smartcart.Tests.Validation.User;

[TestClass]
public class DeleteUserValidationTest : AbstractValidationTest<DeleteUserValidation, DeleteUserCommand>
{
    [TestMethod]
    public async Task DeleteUserValidation()
    {
        var dto = new DeleteUserDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteUserCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteUserValidationFalse()
    {
        var dto = new DeleteUserDTO()
        {
            Id = ""
        };
        
        var command = new DeleteUserCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}