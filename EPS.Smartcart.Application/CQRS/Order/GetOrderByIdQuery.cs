using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Order;

public class GetOrderByIdQuery : IRequest<Domain.Order>
{
    public string Id { get; }
    
    public GetOrderByIdQuery(string id)
    {
        Id = id;
    }
}

public class GetOrderByIdQueryHandler : AbstractHandler, IRequestHandler<GetOrderByIdQuery, Domain.Order>
{
    public GetOrderByIdQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Order> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var order = await _uow.OrderRepository.GetById(request.Id);
        return order;
    }
}