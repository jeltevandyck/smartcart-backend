using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class OrderItemRepositoryMock : AbstractMockRepository<IFilter<OrderItem>, OrderItem, IRepository<OrderItem>>
{
    public override List<OrderItem> CreateData()
    {
        var orderItems = new List<OrderItem>();
        
        orderItems.Add(new OrderItem
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Amount = 1,
            OrderId = "c0a80101-0000-0000-0000-000000000001",
            ProductId = "c0a80101-0000-0000-0000-000000000001"
        });
        
        orderItems.Add(new OrderItem
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            Amount = 1,
            OrderId = "c0a80101-0000-0000-0000-000000000001",
            ProductId = "c0a80101-0000-0000-0000-000000000002"
        });
        
        return orderItems;
    }
}