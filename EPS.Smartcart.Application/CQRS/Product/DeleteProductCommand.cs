using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Product;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Product;

public class DeleteProductCommand : IRequest<Domain.Product>
{
    public DeleteProductDTO ProductDTO { get; }
    
    public DeleteProductCommand(DeleteProductDTO productDTO)
    {
        ProductDTO = productDTO;
    }
}

public class DeleteProductCommandHandler : AbstractHandler, IRequestHandler<DeleteProductCommand, Domain.Product>
{
    public DeleteProductCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _uow.ProductRepository.GetById(request.ProductDTO.Id);
        
        product = _mapper.Map(request.ProductDTO, product);
        _uow.ProductRepository.Delete(product);
        await _uow.Commit();
        
        return product;
    }
}