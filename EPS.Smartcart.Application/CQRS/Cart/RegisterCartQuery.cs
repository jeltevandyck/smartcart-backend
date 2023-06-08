using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain.Types;
using EPS.Smartcart.DTO.Cart;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Cart;

public class RegisterCartQuery : IRequest<Domain.Cart>
{
    public RegisterCartDTO RegisterCartDTO { get; }
    
    public RegisterCartQuery(RegisterCartDTO registerCartDTO)
    {
        RegisterCartDTO = registerCartDTO;
    }
}

public class RegisterCartQueryHandler : AbstractHandler, IRequestHandler<RegisterCartQuery, Domain.Cart>
{
    public RegisterCartQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Cart> Handle(RegisterCartQuery request, CancellationToken cancellationToken)
    {
        var cart = await _uow.CartRepository.GetById(request.RegisterCartDTO.Id);

        cart.Status = CartStatus.ACTIVE;

        if (!String.IsNullOrEmpty(request.RegisterCartDTO.UserId))
        {
            cart.UserId = request.RegisterCartDTO.UserId;
        }
        else
        {
            cart.UserId = null;
        }

        cart = _uow.CartRepository.Update(cart);
        await _uow.Commit();
        return cart;
    }
}