using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Order;

public class UpdateOrderValidation : AbstractValidationHandler<UpdateOrderCommand>
{
    public UpdateOrderValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.OrderDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.OrderDTO.Id)
            .MustAsync(async (x, id, cancellationToken) =>
            {
                var order = await uow.OrderRepository.GetById(id);
                return order != null;
            })
            .WithMessage("Order does not exist!");

        /*RuleFor(x => x.OrderDTO.CartId)
            .MustAsync(async (x, cartId, cancellationToken) =>
            {
                var cart = await uow.CartRepository.GetById(cartId);
                return cart != null;
            })
            .WithMessage("Cart does not exist!");*/
    }
}