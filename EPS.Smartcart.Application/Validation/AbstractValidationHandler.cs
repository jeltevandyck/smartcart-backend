using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation;

public class AbstractValidationHandler<T> : AbstractValidator<T>
{
    public IUnitOfWork _uow { get; }
    
    public AbstractValidationHandler(IUnitOfWork uow)
    {
        _uow = uow;
    }
}