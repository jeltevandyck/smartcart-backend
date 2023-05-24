using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Application.Utils;
using EPS.Smartcart.DTO.Cart;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Cart;

public class UpdateCartCommand : IRequest<Domain.Cart>
{
    public UpdateCartDTO CartDTO { get; }

    public UpdateCartCommand(UpdateCartDTO cartDTO)
    {
        CartDTO = cartDTO;
    }
}

public class UpdateCartCommandHandler : AbstractHandler, IRequestHandler<UpdateCartCommand, Domain.Cart>
{
    public UpdateCartCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Cart> Handle(UpdateCartCommand request, CancellationToken cancellationToken)
    {
        var cart = await _uow.CartRepository.GetById(request.CartDTO.Id);
        
        if (request.CartDTO.ChangeCode)
        {
            cart.Code = CodeUtil.Generate(5);
        }

        cart = _mapper.Map(request.CartDTO, cart);
        cart = _uow.CartRepository.Update(cart);
        await _uow.Commit();
        
        return cart;
    }
}