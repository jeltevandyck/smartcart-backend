using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.DTO.Store;

namespace EPS.Smartcart.Tests.CQRS.Store;

[TestClass]
public class CreateStoreCommandTest : AbstractCQRSHelper<CreateStoreCommandHandler>
{
    [TestMethod]
    public async Task CreateStore()
    {
        var dto = new CreateStoreDTO()
        {
            Name = "Test",
            AddressId = "c0a80101-0000-0000-0000-000000000001"
        };

        var command = new CreateStoreCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}