using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Interfaces;

public interface IUnitOfWork
{
    public IRepository<User> UserRepository { get; }
    public IRepository<Address> AddressRepository { get; }
    public IRepository<Cart> CartRepository { get; }
    public IRepository<Store> StoreRepository { get; }
    public IRepository<Product> ProductRepository { get; }

    Task Commit();
}