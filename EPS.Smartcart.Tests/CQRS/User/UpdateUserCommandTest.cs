using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.DTO.User;

namespace EPS.Smartcart.Tests.CQRS.User;

[TestClass]
public class UpdateUserCommandTest : AbstractCQRSHelper<UpdateUserCommandHandler>
{
    [TestMethod]
    public async Task UpdateUser()
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
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}