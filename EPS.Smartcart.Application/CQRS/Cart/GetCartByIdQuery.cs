using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Cart;

public class GetCartByIdQuery : IRequest<Domain.Cart>
{
    public string Id { get; }

    public GetCartByIdQuery(string id)
    {
        Id = id;
    }
}

public class GetCartByIdQueryHandler : AbstractHandler, IRequestHandler<GetCartByIdQuery, Domain.Cart>
{
    public GetCartByIdQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Cart> Handle(GetCartByIdQuery request, CancellationToken cancellationToken)
    {
        var cart = await _uow.CartRepository.GetById(request.Id);
        return cart;
    }
}