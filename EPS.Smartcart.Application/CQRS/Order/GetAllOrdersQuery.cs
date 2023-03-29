using AutoMapper;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Order;

public class GetAllOrdersQuery : IRequest<IEnumerable<Domain.Order>>
{
    public OrderFilter EntityFilter { get; }
    public PaginationFilter<Domain.Order> PageFilter { get; }
    
    public GetAllOrdersQuery(OrderFilter entityFilter, PaginationFilter<Domain.Order> pageFilter)
    {
        EntityFilter = entityFilter;
        PageFilter = pageFilter;
    }
}

public class GetAllOrdersQueryHandler : AbstractHandler, IRequestHandler<GetAllOrdersQuery, IEnumerable<Domain.Order>>
{
    public GetAllOrdersQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<IEnumerable<Domain.Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = await _uow.OrderRepository.GetAll(request.EntityFilter, request.PageFilter);
        return orders;
    }
}