using EPS.Smartcart.Application.CQRS.Cart;

namespace EPS.Smartcart.Tests.CQRS.Cart;

[TestClass]
public class GetCartByIdQueryTest : AbstractCQRSHelper<GetCartByIdQueryHandler>
{
    [TestMethod]
    public async Task GetCartById()
    {
        var query = new GetCartByIdQuery("c0a80101-0000-0000-0000-000000000001");
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}