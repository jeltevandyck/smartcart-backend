using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;

namespace EPS.Smartcart.Infrastructure.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly SmartcartContext _context;
    
    public IRepository<User> UserRepository { get; }
    public IRepository<Address> AddressRepository { get; }
    public IRepository<Cart> CartRepository { get; }
    public IRepository<Store> StoreRepository { get; }
    public IRepository<Product> ProductRepository { get; }
    public IRepository<Order> OrderRepository { get; }
    public IRepository<OrderItem> OrderItemRepository { get; }

    public UnitOfWork(SmartcartContext context, IRepository<User> userRepository, IRepository<Address> addressRepository, IRepository<Cart> cartRepository, IRepository<Store> storeRepository, IRepository<Product> productRepository, IRepository<Order> orderRepository, IRepository<OrderItem> orderItemRepository)
    {
        _context = context;
        UserRepository = userRepository;
        AddressRepository = addressRepository;
        CartRepository = cartRepository;
        StoreRepository = storeRepository;
        ProductRepository = productRepository;
        OrderRepository = orderRepository;
        OrderItemRepository = orderItemRepository;
    }

    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }
}