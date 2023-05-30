using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class StoreRepositoryMock : AbstractMockRepository<StoreFilter, Store, IRepository<Store>>
{
    public override List<Store> CreateData()
    {
        var stores = new List<Store>();
        return stores;
    }
}