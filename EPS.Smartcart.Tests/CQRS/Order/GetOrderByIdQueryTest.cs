using EPS.Smartcart.Application.CQRS.Order;

namespace EPS.Smartcart.Tests.CQRS.Order;

[TestClass]
public class GetOrderByIdQueryTest : AbstractCQRSHelper<GetOrderByIdQueryHandler>
{
    [TestMethod]
    public async Task GetOrderById()
    {
        var query = new GetOrderByIdQuery("c0a80101-0000-0000-0000-000000000001");
        var result = await _handler.Handle(query, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}