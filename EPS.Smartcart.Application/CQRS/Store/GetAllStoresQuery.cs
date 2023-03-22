using AutoMapper;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Store;

public class GetAllStoresQuery : IRequest<IEnumerable<Domain.Store>>
{
    public StoreFilter EntityFilter { get; }
    public PaginationFilter<Domain.Store> PageFilter { get; }
    
    public GetAllStoresQuery(StoreFilter entityFilter, PaginationFilter<Domain.Store> pageFilter)
    {
        EntityFilter = entityFilter;
        PageFilter = pageFilter;
    }
}

public class GetAllStoresQueryHandler : AbstractHandler, IRequestHandler<GetAllStoresQuery, IEnumerable<Domain.Store>>
{
    public GetAllStoresQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<IEnumerable<Domain.Store>> Handle(GetAllStoresQuery request, CancellationToken cancellationToken)
    {
        var stores = await _uow.StoreRepository.GetAll(request.EntityFilter, request.PageFilter);
        return stores;
    }
}