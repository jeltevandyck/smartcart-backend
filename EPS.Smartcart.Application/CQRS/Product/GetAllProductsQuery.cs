using AutoMapper;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Product;

public class GetAllProductsQuery : IRequest<IEnumerable<Domain.Product>>
{
    public ProductFilter EntityFilter { get; }
    public PaginationFilter<Domain.Product> PageFilter { get; }
    
    public GetAllProductsQuery(ProductFilter entityFilter, PaginationFilter<Domain.Product> pageFilter)
    {
        EntityFilter = entityFilter;
        PageFilter = pageFilter;
    }
}

public class GetAllProductsQueryHandler : AbstractHandler, IRequestHandler<GetAllProductsQuery, IEnumerable<Domain.Product>>
{
    public GetAllProductsQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<IEnumerable<Domain.Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await _uow.ProductRepository.GetAll(request.EntityFilter, request.PageFilter);
        return products;
    }
} 