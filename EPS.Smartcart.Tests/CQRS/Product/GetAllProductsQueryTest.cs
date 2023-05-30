using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Filters;

namespace EPS.Smartcart.Tests.CQRS.Product;

[TestClass]
public class GetAllProductsQueryTest : AbstractCQRSHelper<GetAllProductsQueryHandler>
{
    [TestMethod]
    public async Task GetAllProducts()
    {
        var query = new GetAllProductsQuery(new ProductFilter(), new PaginationFilter<Smartcart.Domain.Product>());
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count());
    }
}