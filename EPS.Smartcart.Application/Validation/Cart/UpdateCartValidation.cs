using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain.Types;
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
        
        RuleFor(x => x.CartDTO.Id)
            .MustAsync(async (x, id, cancellationToken) =>
            {
                if (String.IsNullOrEmpty(id)) return false;
                
                var cart = await uow.CartRepository.GetById(id);
                return cart != null;
            })
            .WithMessage("Id is invalid!");

        RuleFor(x => x.CartDTO.GroceryListId)
            .MustAsync(async (x, groceryListId, cancellationToken) =>
            {
                var groceryList = await uow.GroceryListRepository.GetById(groceryListId);
                if (groceryList == null) return true;

                var cart = await uow.CartRepository.GetById(x.CartDTO.Id);
                if (cart == null) return true;
                
                return groceryList.StoreId == cart.StoreId;
            })
            .WithMessage("GroceryListId is invalid! GroceryList must belong to the same store as the cart.");

        RuleFor(x => x.CartDTO)
            .MustAsync(async (x, cancellationToken) =>
            {
                var cart = await _uow.CartRepository.GetById(x.Id);
                if (cart == null) return true;

                return !(String.IsNullOrEmpty(x.UserId) && !String.IsNullOrEmpty(x.GroceryListId) && cart.Status == CartStatus.ACTIVE);
            })
            .WithMessage("You can't remove the user from an active cart!");

    }
}