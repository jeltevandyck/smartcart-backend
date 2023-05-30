using EPS.Smartcart.Application.CQRS.Store;

namespace EPS.Smartcart.Tests.CQRS.Store;

[TestClass]
public class GetStoreByIdQueryTest : AbstractCQRSHelper<GetStoreByIdQueryHandler>
{
    [TestMethod]
    public async Task GetStoreById()
    {
        var query = new GetStoreByIdQuery("c0a80101-0000-0000-0000-000000000001");
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual("c0a80101-0000-0000-0000-000000000001", result.Id);
    }
}