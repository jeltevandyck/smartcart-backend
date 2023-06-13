using System.Data;
using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Product;

public class CreateProductValidation : AbstractValidationHandler<CreateProductCommand>
{
    public CreateProductValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.ProductDTO.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Name is required!");

        RuleFor(x => x.ProductDTO.Description)
            .NotEmpty()
            .NotNull()
            .WithMessage("Description is required!");

        RuleFor(x => x.ProductDTO.Price)
            .NotNull()
            .WithMessage("Price is required!");

        RuleFor(x => x.ProductDTO.Discount)
            .NotNull()
            .WithMessage("Discount is required!");

        RuleFor(x => x.ProductDTO.DiscountPercentage)
            .NotNull()
            .WithMessage("DiscountPercentage is required!");

        RuleFor(x => x.ProductDTO.Amount)
            .NotNull()
            .WithMessage("Amount is required!");
        
        RuleFor(x => x.ProductDTO.Weight)
            .NotNull()
            .WithMessage("Weight is required!");

        RuleFor(x => x.ProductDTO.ExpirationDate)
            .NotEmpty()
            .NotNull()
            .WithMessage("ExpirationDate is required!");

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