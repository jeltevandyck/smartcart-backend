using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class GroceryListRepositoryMock : AbstractMockRepository<GroceryListFilter, GroceryList, IRepository<GroceryList>>
{
    public override List<GroceryList> CreateData()
    {
        var groceryLists = new List<GroceryList>();
        
        groceryLists.Add(new GroceryList
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            UserId = "c0a80101-0000-0000-0000-000000000001",
            StoreId = "c0a80101-0000-0000-0000-000000000001",
            Note = "Test"
        });
        
        groceryLists.Add(new GroceryList
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            UserId = "c0a80101-0000-0000-0000-000000000001",
            StoreId = "c0a80101-0000-0000-0000-000000000001",
            Note = "Test"
        });
        
        return groceryLists;
    }
}