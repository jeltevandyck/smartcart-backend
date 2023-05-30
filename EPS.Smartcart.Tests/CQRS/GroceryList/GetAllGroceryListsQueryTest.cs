using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Filters;

namespace EPS.Smartcart.Tests.CQRS.GroceryList;

[TestClass]
public class GetAllGroceryListsQueryTest : AbstractCQRSHelper<GetAllGroceryListsQueryHandler>
{
    [TestMethod]
    public async Task GetAllGroceryLists()
    {
        var query = new GetAllGroceryListsQuery(new GroceryListFilter(), new PaginationFilter<Smartcart.Domain.GroceryList>());
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count());
    }
}