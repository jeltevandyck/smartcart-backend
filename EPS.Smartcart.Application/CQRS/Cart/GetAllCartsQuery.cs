using AutoMapper;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Cart;

public class GetAllCartsQuery : IRequest<IEnumerable<Domain.Cart>>
{
    public CartFilter EntityFilter { get; }
    public PaginationFilter<Domain.Cart> PageFilter { get; }

    public GetAllCartsQuery(CartFilter entityFilter, PaginationFilter<Domain.Cart> pageFilter)
    {
        EntityFilter = entityFilter;
        PageFilter = pageFilter;
    }
}

public class GetAllCartsQueryHandler : AbstractHandler, IRequestHandler<GetAllCartsQuery, IEnumerable<Domain.Cart>>
{
    public GetAllCartsQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<IEnumerable<Domain.Cart>> Handle(GetAllCartsQuery request, CancellationToken cancellationToken)
    {
        var addresses = await _uow.CartRepository.GetAll(request.EntityFilter, request.PageFilter);
        return addresses;
    }
}