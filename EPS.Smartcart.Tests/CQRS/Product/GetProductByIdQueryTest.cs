using EPS.Smartcart.Application.CQRS.Product;

namespace EPS.Smartcart.Tests.CQRS.Product;

[TestClass]
public class GetProductByIdQueryTest : AbstractCQRSHelper<GetProductByIdQueryHandler>
{
    [TestMethod]
    public async Task GetProductById()
    {
        var query = new GetProductByIdQuery("c0a80101-0000-0000-0000-000000000001");
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}