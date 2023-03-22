using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Cart;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Cart;

public class CreateCartCommand : IRequest<Domain.Cart>
{
    public CreateCartDTO CartDTO { get; }

    public CreateCartCommand(CreateCartDTO cartDto)
    {
        CartDTO = cartDto;
    }
}

public class CreateCartCommandHandler : AbstractHandler, IRequestHandler<CreateCartCommand,Domain.Cart>
{
    public CreateCartCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Cart> Handle(CreateCartCommand request, CancellationToken cancellationToken)
    {
        var cart = _mapper.Map<Domain.Cart>(request.CartDTO);

        cart.Id = Guid.NewGuid().ToString();

        _uow.CartRepository.Create(cart);
        await _uow.Commit();

        return cart;
    }
}