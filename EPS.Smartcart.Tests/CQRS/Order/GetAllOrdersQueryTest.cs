using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Filters;

namespace EPS.Smartcart.Tests.CQRS.Order;

[TestClass]
public class GetAllOrdersQueryTest : AbstractCQRSHelper<GetAllOrdersQueryHandler>
{
    [TestMethod]
    public async Task GetAllOrders()
    {
        var query = new GetAllOrdersQuery(new OrderFilter(), new PaginationFilter<Smartcart.Domain.Order>());
        var result = await _handler.Handle(query, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
    
}