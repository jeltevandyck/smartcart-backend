using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain.Types;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Cart;

public class UnregisterCartValidation : AbstractValidationHandler<UnregisterCartQuery>
{
    public UnregisterCartValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.UnregisterCartDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.UnregisterCartDTO.Code)
            .NotEmpty()
            .NotNull()
            .WithMessage("Code is required!");

        RuleFor(x => x.UnregisterCartDTO.StoreId)
            .NotEmpty()
            .NotNull()
            .WithMessage("StoreId is required!");

        RuleFor(x => x.UnregisterCartDTO.Id)
            .MustAsync(async (x, id, cancellationToken) =>
            {
                var cart = await uow.CartRepository.GetById(id);
                return cart != null;
            })
            .WithMessage("Id is invalid!");

        RuleFor(x => x.UnregisterCartDTO.Code)
            .MustAsync(async (x, code, cancellationToken) =>
            {
                var cart = await uow.CartRepository.GetById(x.UnregisterCartDTO.Id);
                if (cart == null) return true;
                
                return cart.Code == code;
            })
            .WithMessage("Code is invalid!");

        RuleFor(x => x.UnregisterCartDTO)
            .MustAsync(async (x, cancellationToken) =>
            {
                var cart = await _uow.CartRepository.GetById(x.Id);
                if (cart == null) return true;

                return cart.Status != CartStatus.STANDBY;
            })
            .WithMessage("Cart is already on standby!");
        
        RuleFor(x => x.UnregisterCartDTO.StoreId)
            .MustAsync(async (x, storeId, cancellationToken) =>
            {
                var cart = await _uow.CartRepository.GetById(x.UnregisterCartDTO.Id);
                if (cart == null) return true;
                
                var store = await _uow.StoreRepository.GetById(storeId);
                if (store == null) return true;
                
                return cart.StoreId == storeId;
            })
            .WithMessage("StoreId is invalid! Cart must belong to the same store.");
    }
}