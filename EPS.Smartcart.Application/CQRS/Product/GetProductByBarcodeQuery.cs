using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Product;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Product;

public class GetProductByBarcodeQuery : IRequest<Domain.Product>
{
    public GetProductByBarcodeDTO GetProductByBarcodeDTO { get; }
    
    public GetProductByBarcodeQuery(GetProductByBarcodeDTO getProductByBarcodeDTO)
    {
        GetProductByBarcodeDTO = getProductByBarcodeDTO;
    }
}

public class GetProductByBarcodeQueryHandler : AbstractHandler, IRequestHandler<GetProductByBarcodeQuery, Domain.Product>
{
    public GetProductByBarcodeQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Product> Handle(GetProductByBarcodeQuery request, CancellationToken cancellationToken)
    {
        var products = await _uow.ProductRepository
            .Query(
                x => x.Barcode.Equals(request.GetProductByBarcodeDTO.Barcode) 
                     && x.StoreId.Equals(request.GetProductByBarcodeDTO.StoreId));
        
        if (products.Count == 1) return products[0];
        else return null;
    }
}