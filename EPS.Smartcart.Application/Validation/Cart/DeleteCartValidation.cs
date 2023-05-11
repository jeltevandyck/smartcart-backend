using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Cart;

public class DeleteCartValidation : AbstractValidationHandler<DeleteCartCommand>
{
    public DeleteCartValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.CartDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.CartDTO.Id)
            .MustAsync(async (x, id, cancellationToken) =>
            {
                var cart = await uow.CartRepository.GetById(id);
                return cart != null;
            })
            .WithMessage("Cart does not exist!");
    }
}