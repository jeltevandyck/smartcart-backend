using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class GroceryItemRepositoryMock : AbstractMockRepository<IFilter<GroceryItem>, GroceryItem, IRepository<GroceryItem>>
{
    public override List<GroceryItem> CreateData()
    {
        var groceryItems = new List<GroceryItem>();
        return groceryItems;
    }
}