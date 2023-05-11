using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Cart;

public class UpdateCartValidation : AbstractValidationHandler<UpdateCartCommand>
{
    public UpdateCartValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.CartDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.CartDTO.StoreId)
            .NotEmpty()
            .NotNull()
            .MustAsync(async (x, storeId, cancellationToken) =>
            {
                var store = await uow.StoreRepository.GetById(storeId);
                return store != null;
                
                return false;
            })
            .WithMessage("StoreId is invalid!");
    }
}