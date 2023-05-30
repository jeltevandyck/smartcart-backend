using EPS.Smartcart.Application.CQRS.Address;

namespace EPS.Smartcart.Tests.CQRS;

[TestClass]
public class GetAddressByIdQueryTest : AbstractCQRSHelper<GetAddressByIdQueryHandler>
{
    [TestMethod]
    public async Task GetAddressById()
    {
        var query = new GetAddressByIdQuery("c0a80101-0000-0000-0000-000000000001");

        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual("c0a80101-0000-0000-0000-000000000001", result.Id);
    }
}