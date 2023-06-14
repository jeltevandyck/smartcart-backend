using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.GroceryList;

public class ResetGroceryListValidation : AbstractValidationHandler<ResetGroceryListQuery>
{
    public ResetGroceryListValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.ResetGroceryListDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.ResetGroceryListDTO.Id)
            .MustAsync(async (id, cancellationToken) =>
            {
                var groceryList = await _uow.GroceryListRepository.GetById(id);
                return groceryList != null;
            })
            .WithMessage("GroceryList does not exist!");
    }
}