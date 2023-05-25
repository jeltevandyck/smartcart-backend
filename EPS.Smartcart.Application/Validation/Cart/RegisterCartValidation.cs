using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain.Types;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Cart;

public class RegisterCartValidation : AbstractValidationHandler<RegisterCartQuery>
{
    public RegisterCartValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.RegisterCartDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
        
        RuleFor(x => x.RegisterCartDTO.UserId)
            .NotEmpty()
            .NotNull()
            .WithMessage("UserId is required!");

        RuleFor(x => x.RegisterCartDTO.Code)
            .NotEmpty()
            .NotNull()
            .WithMessage("Code is required!");
        
        RuleFor(x => x.RegisterCartDTO.Id)
            .MustAsync(async (x, id, cancellationToken) =>
            {
                var cart = await uow.CartRepository.GetById(id);
                return cart != null;
            })
            .WithMessage("Id is invalid!");
        
        RuleFor(x => x.RegisterCartDTO.UserId)
            .MustAsync(async (x, userId, cancellationToken) =>
            {
                var user = await uow.UserRepository.GetById(userId);
                return user != null;
            })
            .WithMessage("UserId is invalid!");

        RuleFor(x => x.RegisterCartDTO.Code)
            .MustAsync(async (x, code, cancellationToken) =>
            {
                var cart = await uow.CartRepository.GetById(x.RegisterCartDTO.Id);
                if (cart == null) return true;
                
                return cart.Code == code;
            })
            .WithMessage("Code is invalid!");

        RuleFor(x => x.RegisterCartDTO)
            .MustAsync(async (x, cancellationToken) =>
            {
                var cart = await _uow.CartRepository.GetById(x.Id);
                if (cart == null) return true;

                return cart.Status == CartStatus.STANDBY;
            })
            .WithMessage("Cart is already active!");
        
        RuleFor(x => x.RegisterCartDTO.StoreId)
            .MustAsync(async (x, storeId, cancellationToken) =>
            {
                var cart = await _uow.CartRepository.GetById(x.RegisterCartDTO.Id);
                if (cart == null) return true;
                
                var store = await _uow.StoreRepository.GetById(storeId);
                if (store == null) return true;
                
                return cart.StoreId == storeId;
            })
            .WithMessage("StoreId is invalid! Cart must belong to the same store.");
    }
}