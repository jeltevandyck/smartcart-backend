using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;
using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class CartRepositoryMock : AbstractMockRepository<CartFilter, Cart, IRepository<Cart>>
{
    public override List<Cart> CreateData()
    {
        var carts = new List<Cart>();

        carts.Add(new Cart
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            StoreId = "c0a80101-0000-0000-0000-000000000001",
            Status = CartStatus.STANDBY,
            Code = "12345678"
        });
        
        carts.Add(new Cart
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            StoreId = "c0a80101-0000-0000-0000-000000000001",
            Status = CartStatus.STANDBY,
            Code = "12345678"
        });

        return carts;
    }
}