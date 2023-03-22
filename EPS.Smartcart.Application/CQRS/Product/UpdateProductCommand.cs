using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Product;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Product;

public class UpdateProductCommand : IRequest<Domain.Product>
{
    public UpdateProductDTO ProductDTO { get; }
    
    public UpdateProductCommand(UpdateProductDTO productDTO)
    {
        ProductDTO = productDTO;
    }
}

public class UpdateProductCommandHandler : AbstractHandler, IRequestHandler<UpdateProductCommand, Domain.Product>
{
    public UpdateProductCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _uow.ProductRepository.GetById(request.ProductDTO.Id);
        
        product = _mapper.Map(request.ProductDTO, product);
        product = _uow.ProductRepository.Update(product);
        await _uow.Commit();
        
        return product;
    }
}