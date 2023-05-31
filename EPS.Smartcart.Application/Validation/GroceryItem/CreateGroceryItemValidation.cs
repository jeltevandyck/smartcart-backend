using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.GroceryItem;

public class CreateGroceryItemValidation : AbstractValidationHandler<CreateGroceryItemCommand>
{
    public CreateGroceryItemValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.GroceryItemDTO.Amount)
            .NotEmpty()
            .NotNull()
            .WithMessage("Amount is required!");
        
        RuleFor(x => x.GroceryItemDTO.ProductId)
            .NotEmpty()
            .NotNull()
            .WithMessage("ProductId is required!");
    }
}