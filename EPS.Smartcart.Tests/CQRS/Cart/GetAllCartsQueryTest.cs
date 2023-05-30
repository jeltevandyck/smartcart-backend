using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Filters;

namespace EPS.Smartcart.Tests.CQRS.Cart;

[TestClass]
public class GetAllCartsQueryTest : AbstractCQRSHelper<GetAllCartsQueryHandler>
{
    [TestMethod]
    public async Task GetAllCarts()
    {
        var query = new GetAllCartsQuery(new CartFilter(), new PaginationFilter<Smartcart.Domain.Cart>());
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
    }
    
}