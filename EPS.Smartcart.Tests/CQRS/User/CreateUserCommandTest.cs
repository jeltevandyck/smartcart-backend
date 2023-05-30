using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.DTO.User;

namespace EPS.Smartcart.Tests.CQRS.User;

[TestClass]
public class CreateUserCommandTest : AbstractCQRSHelper<CreateUserCommandHandler>
{
    [TestMethod]
    public async Task CreateUser()
    {
        var dto = new CreateUserDTO()
        {
            FirstName = "Test",
            LastName = "Test",
            Email = "test@gmail.com",
            BirthDate = DateTime.Parse("1990-01-01"),
        };

        var command = new CreateUserCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}