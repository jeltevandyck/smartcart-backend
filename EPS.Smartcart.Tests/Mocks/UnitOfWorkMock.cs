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
        
        unitOfWork.Setup(x => x.AddressRepository).Returns(addressRepo.Object);
        
        return unitOfWork.Object;
    }
}