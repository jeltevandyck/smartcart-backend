using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Filters;

namespace EPS.Smartcart.Tests.CQRS.Store;

[TestClass]
public class GetAllStoresQueryTest : AbstractCQRSHelper<GetAllStoresQueryHandler>
{
    [TestMethod]
    public async Task GetAllStores()
    {
        var query = new GetAllStoresQuery(new StoreFilter(), new PaginationFilter<Smartcart.Domain.Store>());
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.IsTrue(result.Count() > 0);
    }
}