using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain.Types;
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

        RuleFor(x => x.OrderDTO.CartId)
            .MustAsync(async (cartId, cancellationToken) =>
            {
                var cart = await _uow.CartRepository.GetById(cartId);
                return cart != null;
            })
            .WithMessage("CartId is invalid!");
        
        RuleFor(x => x.OrderDTO.CartId)
            .MustAsync(async (cartId, cancellationToken) =>
            {
                var cart = await _uow.CartRepository.GetById(cartId);
                if (cart == null) return true;

                return cart.Status == CartStatus.ACTIVE && String.IsNullOrEmpty(cart.OrderId);
            })
            .WithMessage("Cart has already an order!");
    }
}