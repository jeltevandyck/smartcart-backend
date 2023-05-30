using EPS.Smartcart.Application.CQRS;
using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Tests.Mocks;

namespace EPS.Smartcart.Tests.CQRS;

public abstract class AbstractCQRSHelper<T> where T : AbstractHandler
{
    protected IUnitOfWork _uow;
    protected T _handler;

    public AbstractCQRSHelper()
    {
        _uow = UnitOfWorkMock.GetUnitOfWork();
        var mapper = MapperMock.GetMapper();
        _handler = (T)Activator.CreateInstance(typeof(T), _uow, mapper);
    }

}