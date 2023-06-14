using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain.Types;
using EPS.Smartcart.DTO.Order;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Order;

public class CreateOrderCommand : IRequest<Domain.Order>
{
    public CreateOrderDTO OrderDTO { get; set; }
    
    public CreateOrderCommand(CreateOrderDTO orderDTO)
    {
        OrderDTO = orderDTO;
    }
}

public class CreateOrderCommandHandler : AbstractHandler, IRequestHandler<CreateOrderCommand, Domain.Order>
{
    public CreateOrderCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = _mapper.Map<Domain.Order>(request.OrderDTO);
        
        order.Id = Guid.NewGuid().ToString();
        order.Status = OrderStatus.UNPAID;
        
        var now = DateTime.Now;
        order.CreatedDate = now;
        order.ChangedStatusDate = now;
        
        
        var cart = await _uow.CartRepository.GetById(request.OrderDTO.CartId);
        cart.OrderId = order.Id;

        if (!String.IsNullOrEmpty(cart.UserId)) order.UserId = cart.UserId;
        
        _uow.OrderRepository.Create(order);
        _uow.CartRepository.Update(cart);
        
        await _uow.Commit();
        return order;
    }
}