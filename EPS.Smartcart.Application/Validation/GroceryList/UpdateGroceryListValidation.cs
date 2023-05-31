using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.GroceryList;

public class UpdateGroceryListValidation : AbstractValidationHandler<UpdateGroceryListCommand>
{
    public UpdateGroceryListValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.GroceryListDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.GroceryListDTO.UserId)
            .NotEmpty()
            .NotNull()
            .WithMessage("UserId is required!");

        RuleFor(x => x.GroceryListDTO.StoreId)
            .NotEmpty()
            .NotNull()
            .WithMessage("StoreId is required!");
    }
}