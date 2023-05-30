using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.DTO.User;

namespace EPS.Smartcart.Tests.CQRS.User;

[TestClass]
public class DeleteUserCommandTest : AbstractCQRSHelper<DeleteUserCommandHandler>
{
    [TestMethod]
    public async Task DeleteUser()
    {
        var dto = new DeleteUserDTO()
        {
            Id = Guid.Parse("c0a80101-0000-0000-0000-000000000001").ToString(),
        };

        var command = new DeleteUserCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}