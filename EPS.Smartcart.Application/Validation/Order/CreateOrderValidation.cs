using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Order;

public class CreateOrderValidation : AbstractValidationHandler<CreateOrderCommand>
{
    public CreateOrderValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.OrderDTO.CartId)
            .NotEmpty()
            .NotNull()
            .WithMessage("CartId is required!");
    }
}