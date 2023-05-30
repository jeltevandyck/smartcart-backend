using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.Application.Filters;

namespace EPS.Smartcart.Tests.CQRS.User;

[TestClass]
public class GetAllUsersQueryTest : AbstractCQRSHelper<GetAllUsersQueryHandler>
{
    [TestMethod]
    public async Task GetAllUsers()
    {
        var query = new GetAllUsersQuery(new UserFilter(), new PaginationFilter<Smartcart.Domain.User>());
        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}