using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Tests.Mocks.Repositories;
using Moq;

namespace EPS.Smartcart.Tests.Mocks;

public class UnitOfWorkMock
{
    public static IUnitOfWork GetUnitOfWork()
    {
        var unitOfWork = new Mock<IUnitOfWork>();

        var addressRepo = new AddressRepositoryMock().GetRepository();
        var cartRepo = new CartRepositoryMock().GetRepository();
        var groceryItemRepo = new GroceryItemRepositoryMock().GetRepository();
        var groceryListRepo = new GroceryListRepositoryMock().GetRepository();
        var orderItemRepo = new OrderItemRepositoryMock().GetRepository();
        var orderRepo = new OrderRepositoryMock().GetRepository();
        var productRepo = new ProductRepositoryMock().GetRepository();
        var storeRepo = new StoreRepositoryMock().GetRepository();
        var userRepo = new UserRepositoryMock().GetRepository();
        
        unitOfWork.Setup(x => x.AddressRepository).Returns(addressRepo.Object);
        unitOfWork.Setup(x => x.CartRepository).Returns(cartRepo.Object);
        unitOfWork.Setup(x => x.GroceryItemRepository).Returns(groceryItemRepo.Object);
        unitOfWork.Setup(x => x.GroceryListRepository).Returns(groceryListRepo.Object);
        unitOfWork.Setup(x => x.OrderItemRepository).Returns(orderItemRepo.Object);
        unitOfWork.Setup(x => x.OrderRepository).Returns(orderRepo.Object);
        unitOfWork.Setup(x => x.ProductRepository).Returns(productRepo.Object);
        unitOfWork.Setup(x => x.StoreRepository).Returns(storeRepo.Object);
        unitOfWork.Setup(x => x.UserRepository).Returns(userRepo.Object);

        return unitOfWork.Object;
    }
}