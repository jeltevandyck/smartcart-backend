using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class OrderRepositoryMock : AbstractMockRepository<OrderFilter, Order, IRepository<Order>>
{
    public override List<Order> CreateData()
    {
        var orders = new List<Order>();
        return orders;
    }
}