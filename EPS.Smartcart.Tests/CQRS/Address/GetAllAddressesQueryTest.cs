using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.CQRS;

[TestClass]
public class GetAllAddressesQueryTest : AbstractCQRSHelper<GetAllAddressesQueryHandler>
{
    [TestMethod]
    public async Task GetAllAddresses()
    {
        var query = new GetAllAddressesQuery(new AddressFilter(), new PaginationFilter<Address>());

        var result = await _handler.Handle(query, CancellationToken.None);

        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count());
    }
}