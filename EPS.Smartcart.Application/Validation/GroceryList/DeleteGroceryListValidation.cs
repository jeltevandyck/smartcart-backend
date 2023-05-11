using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.GroceryList;

public class DeleteGroceryListValidation : AbstractValidationHandler<DeleteGroceryListCommand>
{
    public DeleteGroceryListValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.GroceryListDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
    }
}