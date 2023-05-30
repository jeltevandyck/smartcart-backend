using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Cart;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Cart;

public class DeleteCartCommand : IRequest<Domain.Cart>
{
    public DeleteCartDTO CartDTO { get; }

    public DeleteCartCommand(DeleteCartDTO cartDto)
    {
        CartDTO = cartDto;
    }
}

public class DeleteCartCommandHandler : AbstractHandler, IRequestHandler<DeleteCartCommand, Domain.Cart>
{
    public DeleteCartCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }
    
    public async Task<Domain.Cart> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
    {
        var cart = await _uow.CartRepository.GetById(request.CartDTO.Id);

        cart = _mapper.Map(request.CartDTO, cart);
        _uow.CartRepository.Delete(cart);
        await _uow.Commit();

        return cart;
    }
}