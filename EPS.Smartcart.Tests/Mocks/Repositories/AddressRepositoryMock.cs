using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class AddressRepositoryMock : AbstractMockRepository<AddressFilter, Address, IRepository<Address>>
{
    public override List<Address> CreateData()
    {
        var addresses = new List<Address>
        {
            new Address
            {
                Id = "c0a80101-0000-0000-0000-000000000001",
                Street = "Calle 1",
                Number = "1",
                Extra = "Extra 1",
                City = "Ciudad 1",
                PostalCode = "Codigo Postal 1",
                Country = "Pais 1",
                State = "Estado 1"
            },
            new Address
            {
                Id = "c0a80101-0000-0000-0000-000000000002",
                Street = "Calle 2",
                Number = "2",
                Extra = "Extra 2",
                City = "Ciudad 2",
                PostalCode = "Codigo Postal 2",
                Country = "Pais 2",
                State = "Estado 2"
            }
        };

        return addresses;
    }
}