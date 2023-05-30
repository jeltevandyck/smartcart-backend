using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.DTO.Store;

namespace EPS.Smartcart.Tests.CQRS.Store;

[TestClass]
public class DeleteStoreCommandTest : AbstractCQRSHelper<DeleteStoreCommandHandler>
{
    [TestMethod]
    public async Task DeleteStore()
    {
        var dto = new DeleteStoreDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };

        var command = new DeleteStoreCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual("c0a80101-0000-0000-0000-000000000001", result.Id);
    }
}