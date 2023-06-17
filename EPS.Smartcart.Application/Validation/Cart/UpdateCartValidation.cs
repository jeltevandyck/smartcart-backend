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
        
        RuleFor(x => x.CartDTO.IsClaimed)
            .MustAsync(async (command, isClaimed, cancellationToken) =>
            {
                if (isClaimed == null) return true;
                var cartDTO = command.CartDTO;

                var cart = await uow.CartRepository.GetById(cartDTO.Id);

                return !(isClaimed == true && cart.IsClaimed);

            })
            .WithMessage("This cart is already claimed!");
        
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

    }
}