using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class CartRepositoryMock : AbstractMockRepository<CartFilter, Cart, IRepository<Cart>>
{
    public override List<Cart> CreateData()
    {
        var carts = new List<Cart>();
        
        return carts;
    }
}