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

        RuleFor(x => x.GetProductByBarcodeDTO.StoreId)
            .MustAsync(async (storeId, cancellationToken) =>
            {
                var store = await _uow.StoreRepository.GetById(storeId);
                return store != null;
            })
            .WithMessage("StoreId is invalid!");
        
        RuleFor(x => x.GetProductByBarcodeDTO.Barcode)
            .MustAsync(async (barcode, cancellationToken) =>
            {
                var products = await _uow.ProductRepository
                    .Query(
                        x => x.Barcode.Equals(barcode) 
                             && x.StoreId.Equals(x.StoreId));
                
                return products.Count == 1;
            })
            .WithMessage("Product not found!");
    }
}