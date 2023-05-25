using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Application.Utils;
using EPS.Smartcart.Domain.Types;
using EPS.Smartcart.DTO.Cart;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Cart;

public class UnregisterCartQuery : IRequest<Domain.Cart>
{
    public UnregisterCartDTO UnregisterCartDTO { get; }
    
    public UnregisterCartQuery(UnregisterCartDTO unregisterCartDTO)
    {
        UnregisterCartDTO = unregisterCartDTO;
    }
}

public class UnregisterCartQueryHandler : AbstractHandler, IRequestHandler<UnregisterCartQuery, Domain.Cart>
{
    public UnregisterCartQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Cart> Handle(UnregisterCartQuery request, CancellationToken cancellationToken)
    {
        var cart = await _uow.CartRepository.GetById(request.UnregisterCartDTO.Id);

        cart.Status = CartStatus.STANDBY;
        cart.UserId = null;
        cart.GroceryListId = null;
        cart.Code = CodeUtil.Generate(8);
        
        cart = _uow.CartRepository.Update(cart);
        await _uow.Commit();
        return cart;
    }
}