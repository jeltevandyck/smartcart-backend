using EPS.Smartcart.Application.CQRS.User;

namespace EPS.Smartcart.Tests.CQRS.User;

[TestClass]
public class GetUserByIdQueryTest : AbstractCQRSHelper<GetUserByIdQueryHandler>
{
    [TestMethod]
    public async Task GetUserById()
    {
        var query = new GetUserByIdQuery("c0a80101-0000-0000-0000-000000000001");
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
    }
    
}