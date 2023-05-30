using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Address;
using EPS.Smartcart.Tests.Mocks;

namespace EPS.Smartcart.Tests.CQRS;

[TestClass]
public class DeleteAddressCommandTest : AbstractCQRSHelper<DeleteAddressCommandHandler>
{
    [TestMethod]
    public async Task DeleteAddress()
    {
        var dto = new DeleteAddressDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteAddressCommand(dto);

        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual("c0a80101-0000-0000-0000-000000000001", result.Id);
    }
}