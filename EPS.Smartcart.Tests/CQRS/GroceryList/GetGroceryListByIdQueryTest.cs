using EPS.Smartcart.Application.CQRS.GroceryList;

namespace EPS.Smartcart.Tests.CQRS.GroceryList;

[TestClass]
public class GetGroceryListByIdQueryTest : AbstractCQRSHelper<GetGroceryListByIdQueryHandler>
{
    [TestMethod]
    public async Task GetGroceryListById()
    {
        var query = new GetGroceryListByIdQuery("c0a80101-0000-0000-0000-000000000001");
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual("c0a80101-0000-0000-0000-000000000001", result.Id);
    }
}