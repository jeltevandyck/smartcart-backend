using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Product;

public class GetProductByBarcodeValidation : AbstractValidationHandler<GetProductByBarcodeQuery>
{
    public GetProductByBarcodeValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.GetProductByBarcodeDTO.Barcode)
            .NotEmpty()
            .NotNull()
            .WithMessage("Barcode is required!");
        
        RuleFor(x => x.GetProductByBarcodeDTO.StoreId)
            .NotEmpty()
            .NotNull()
            .WithMessage("StoreId is required!");
    }
}