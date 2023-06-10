using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.OrderItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.OrderItem;

public class UpdateOrderItemCommand : IRequest<Domain.Order>
{
    public UpdateOrderItemDTO OrderItemDTO { get; }
    
    public UpdateOrderItemCommand(UpdateOrderItemDTO orderItemDTO)
    {
        OrderItemDTO = orderItemDTO;
    }
}

public class UpdateOrderItemCommandHandler : AbstractHandler, IRequestHandler<UpdateOrderItemCommand, Domain.Order>
{
    public UpdateOrderItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Order> Handle(UpdateOrderItemCommand request, CancellationToken cancellationToken)
    {
        var orderItem = await _uow.OrderItemRepository.GetById(request.OrderItemDTO.Id);

        orderItem = _mapper.Map(request.OrderItemDTO, orderItem);

        _uow.OrderItemRepository.Update(orderItem);
        await _uow.Commit();
        
        var order = await _uow.OrderRepository.GetById(orderItem.OrderId);
        return order;
    }
}