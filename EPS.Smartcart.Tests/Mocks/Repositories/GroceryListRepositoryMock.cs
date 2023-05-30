using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class GroceryListRepositoryMock : AbstractMockRepository<GroceryListFilter, GroceryList, IRepository<GroceryList>>
{
    public override List<GroceryList> CreateData()
    {
        var groceryLists = new List<GroceryList>();
           return groceryLists;
    }
}