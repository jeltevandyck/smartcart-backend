using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.GroceryList;

public class CreateGroceryListValidation : AbstractValidationHandler<CreateGroceryListCommand>
{
    public CreateGroceryListValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.GroceryListDTO.UserId)
            .NotEmpty()
            .NotNull()
            .WithMessage("UserId is required!");
        
        RuleFor(x => x.GroceryListDTO.StoreId)
            .NotEmpty()
            .NotNull()
            .WithMessage("StoreId is required!");
        
        RuleFor(x => x.GroceryListDTO.UserId)
            .MustAsync(async (userId, cancellation) =>
            {
                var user = await _uow.UserRepository.GetById(userId);
                return user != null;
            })
            .WithMessage("User does not exist!");

        RuleFor(x => x.GroceryListDTO.StoreId)
            .MustAsync(async (storeId, cancellation) =>
            {
                var store = await _uow.StoreRepository.GetById(storeId);
                return store != null;
            })
            .WithMessage("Store does not exist!");
    }
}