using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Product;

public class GetProductByIdQuery : IRequest<Domain.Product>
{
    public string Id { get; }
    
    public GetProductByIdQuery(string id)
    {
        Id = id;
    }
}

public class GetProductByIdQueryHandler : AbstractHandler, IRequestHandler<GetProductByIdQuery, Domain.Product>
{
    public GetProductByIdQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _uow.ProductRepository.GetById(request.Id);
        return product;
    }
}