using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Cart;

public class CreateCartValidation : AbstractValidationHandler<CreateCartCommand>
{
    public CreateCartValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.CartDTO.StoreId)
            .NotEmpty()
            .NotNull()
            .WithMessage("StoreId is required!");

        RuleFor(x => x.CartDTO.StoreId)
            .MustAsync(async (x, storeId, cancellationToken) =>
            {
                var store = uow.StoreRepository.GetById(storeId);
                return await store != null;
            })
            .WithMessage("StoreId is invalid!");
    }
}