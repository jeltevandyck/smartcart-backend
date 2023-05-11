using System.Data;
using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Product;

public class UpdateProductValidation : AbstractValidationHandler<UpdateProductCommand>
{
    public UpdateProductValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.ProductDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
        
        RuleFor(x => x.ProductDTO.StoreId)
            .NotEmpty()
            .NotNull()
            .WithMessage("StoreId is required!");
        
        RuleFor(x => x.ProductDTO.StoreId)
            .MustAsync(async (x, storeId, cancellationToken) =>
            {
                var store = await uow.StoreRepository.GetById(storeId);
                return store != null;
            })
            .WithMessage("StoreId is invalid!");
    }
}