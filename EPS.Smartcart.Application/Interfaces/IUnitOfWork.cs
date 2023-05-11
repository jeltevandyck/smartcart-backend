using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Interfaces;

public interface IUnitOfWork
{
    public IRepository<User> UserRepository { get; }
    public IRepository<Address> AddressRepository { get; }
    public IRepository<Cart> CartRepository { get; }
    public IRepository<Store> StoreRepository { get; }
    public IRepository<Product> ProductRepository { get; }
    public IRepository<Order> OrderRepository { get; }
    public IRepository<OrderItem> OrderItemRepository { get; }
    public IRepository<GroceryList> GroceryListRepository { get; }
    public IRepository<GroceryItem> GroceryItemRepository { get; }

    Task Commit();
}