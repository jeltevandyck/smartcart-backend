using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.Application.Validation.User;
using EPS.Smartcart.DTO.User;

namespace EPS.Smartcart.Tests.Validation.User;

[TestClass]
public class UpdateUserValidationTest : AbstractValidationTest<UpdateUserValidation, UpdateUserCommand>
{
    [TestMethod]
    public async Task UpdateUserValidation()
    {
        var dto = new UpdateUserDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            FirstName = "Test",
            LastName = "Test",
            Email = "test@gmail.com",
            BirthDate = DateTime.Parse("1990-01-01"),
        };

        var command = new UpdateUserCommand(dto);
        var result = await Validation.ValidateAsync(command);

        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task UpdateUserValidationFalse()
    {
        var dto = new UpdateUserDTO()
        {
            Id = "",
            FirstName = "",
            LastName = "",
            Email = "",
            BirthDate = DateTime.Parse("1990-01-01"),
        };

        var command = new UpdateUserCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}