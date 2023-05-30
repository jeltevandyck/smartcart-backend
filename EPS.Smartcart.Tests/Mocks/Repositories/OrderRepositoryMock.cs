using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;
using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class OrderRepositoryMock : AbstractMockRepository<OrderFilter, Order, IRepository<Order>>
{
    public override List<Order> CreateData()
    {
        var orders = new List<Order>();
        
        orders.Add(new Order
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            CartId = "c0a80101-0000-0000-0000-000000000001",
            Status = OrderStatus.UNPAID,
            CreatedDate = new DateTime(2021, 1, 1, 10, 0, 0),
            ChangedStatusDate = new DateTime(2021, 1, 1, 10, 0, 0)
        });
        
        orders.Add(new Order
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            CartId = "c0a80101-0000-0000-0000-000000000002",
            Status = OrderStatus.UNPAID,
            CreatedDate = new DateTime(2021, 1, 1, 10, 0, 0),
            ChangedStatusDate = new DateTime(2021, 1, 1, 10, 0, 0)
        });
        
        return orders;
    }
}