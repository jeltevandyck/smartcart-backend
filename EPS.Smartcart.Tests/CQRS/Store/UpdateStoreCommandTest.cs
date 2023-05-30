using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.DTO.Store;

namespace EPS.Smartcart.Tests.CQRS.Store;

[TestClass]
public class UpdateStoreCommandTest : AbstractCQRSHelper<UpdateStoreCommandHandler>
{
    [TestMethod]
    public async Task UpdateStore()
    {
        var dto = new UpdateStoreDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Name = "Test",
            AddressId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new UpdateStoreCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}