using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.Application.Validation.User;
using EPS.Smartcart.DTO.User;

namespace EPS.Smartcart.Tests.Validation.User;

[TestClass]
public class CreateUserValidationTest : AbstractValidationTest<CreateUserValidation, CreateUserCommand>
{
    [TestMethod]
    public async Task CreateUserValidation()
    {
        var dto = new CreateUserDTO()
        {
            FirstName = "Test",
            LastName = "Test",
            Email = "test@gmail.com",
            BirthDate = DateTime.Parse("1990-01-01"),
        };

        var command = new CreateUserCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateUserValidationFalse()
    {
        var dto = new CreateUserDTO()
        {
            FirstName = "",
            LastName = "",
            Email = "",
            BirthDate = DateTime.Parse("1990-01-01"),
        };

        var command = new CreateUserCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}