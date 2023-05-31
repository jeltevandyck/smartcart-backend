using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Application.Validation;
using EPS.Smartcart.Tests.Mocks;
using MediatR;

namespace EPS.Smartcart.Tests.Validation;

public abstract class AbstractValidationTest<T,V> where T : AbstractValidationHandler<V>
{
    protected IUnitOfWork Uow;
    protected T Validation;

    protected AbstractValidationTest()
    {
        Uow = UnitOfWorkMock.GetUnitOfWork();
        Validation = (T)Activator.CreateInstance(typeof(T), Uow);
    }
}