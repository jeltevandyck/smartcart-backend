using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Order;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Order;

public class UpdateOrderCommand : IRequest<Domain.Order>
{
    public UpdateOrderDTO OrderDTO { get; }
    
    public UpdateOrderCommand(UpdateOrderDTO orderDTO)
    {
        OrderDTO = orderDTO;
    }
}

public class UpdateOrderCommandHandler : AbstractHandler, IRequestHandler<UpdateOrderCommand, Domain.Order>
{
    public UpdateOrderCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Order> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = await _uow.OrderRepository.GetById(request.OrderDTO.Id);

        order = _mapper.Map(request.OrderDTO, order);
        if (request.OrderDTO.OrderStatus != null) order.Status = request.OrderDTO.OrderStatus.Value;
        
        _uow.OrderRepository.Update(order);
        
        await _uow.Commit();
        return order;
    }
}