using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Cart;
using EPS.Smartcart.DTO.Product;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Product;

public class CreateProductCommand : IRequest<Domain.Product>
{
    public CreateProductDTO ProductDTO { get; }

    public CreateProductCommand(CreateProductDTO productDto)
    {
        ProductDTO = productDto;
    }
}

public class CreateProductCommandHandler : AbstractHandler, IRequestHandler<CreateProductCommand, Domain.Product>
{
    public CreateProductCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = _mapper.Map<Domain.Product>(request.ProductDTO);
        product.Id = Guid.NewGuid().ToString();
        
        _uow.ProductRepository.Create(product);
        await _uow.Commit();
        return product;
    }
}



