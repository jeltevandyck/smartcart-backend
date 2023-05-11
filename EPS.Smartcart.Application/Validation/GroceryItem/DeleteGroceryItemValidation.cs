using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.GroceryItem;

public class DeleteGroceryItemValidation : AbstractValidationHandler<DeleteGroceryItemCommand>
{
    public DeleteGroceryItemValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.GroceryItemDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
    }
}