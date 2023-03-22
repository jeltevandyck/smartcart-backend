using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Store;

public class GetStoreByIdQuery : IRequest<Domain.Store>
{
    public string Id { get; }
    
    public GetStoreByIdQuery(string id)
    {
        Id = id;
    }
}

public class GetStoreByIdQueryHandler : AbstractHandler, IRequestHandler<GetStoreByIdQuery, Domain.Store>
{
    public GetStoreByIdQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Store> Handle(GetStoreByIdQuery request, CancellationToken cancellationToken)
    {
        var store = await _uow.StoreRepository.GetById(request.Id);
        return store;
    }
}