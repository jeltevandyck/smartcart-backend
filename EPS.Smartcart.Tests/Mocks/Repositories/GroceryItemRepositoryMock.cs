using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class GroceryItemRepositoryMock : AbstractMockRepository<IFilter<GroceryItem>, GroceryItem, IRepository<GroceryItem>>
{
    public override List<GroceryItem> CreateData()
    {
        var groceryItems = new List<GroceryItem>();
        
        groceryItems.Add(new GroceryItem
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
            IsCollected = false,
            GroceryListId = "c0a80101-0000-0000-0000-000000000001",
            ProductId = "c0a80101-0000-0000-0000-000000000001"
        });
        
        groceryItems.Add(new GroceryItem
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            Amount = 1,
            IsCollected = false,
            GroceryListId = "c0a80101-0000-0000-0000-000000000001",
            ProductId = "c0a80101-0000-0000-0000-000000000002"
        });
        
        return groceryItems;
    }
}