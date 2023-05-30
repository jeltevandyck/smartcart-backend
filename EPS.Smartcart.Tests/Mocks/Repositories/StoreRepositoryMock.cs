using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class StoreRepositoryMock : AbstractMockRepository<StoreFilter, Store, IRepository<Store>>
{
    public override List<Store> CreateData()
    {
        var stores = new List<Store>();
        
        stores.Add(new Store
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Name = "Test",
            AddressId = "c0a80101-0000-0000-0000-000000000001"
        });
        
        stores.Add(new Store
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            Name = "Test 2",
            AddressId = "c0a80101-0000-0000-0000-000000000001"
        });
        
        return stores;
    }
}