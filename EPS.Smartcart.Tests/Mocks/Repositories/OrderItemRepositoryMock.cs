using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class OrderItemRepositoryMock : AbstractMockRepository<IFilter<OrderItem>, OrderItem, IRepository<OrderItem>>
{
    public override List<OrderItem> CreateData()
    {
        var orderItems = new List<OrderItem>();
        return orderItems;
    }
}