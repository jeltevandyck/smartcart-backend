using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.OrderItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.OrderItem;

public class CreateOrderItemCommand : IRequest<Domain.Order>
{
    public CreateOrderItemDTO OrderItemDTO { get; set; }
    
    public CreateOrderItemCommand(CreateOrderItemDTO orderItemDTO)
    {
        OrderItemDTO = orderItemDTO;
    }
}

public class CreateOrderItemCommandHandler : AbstractHandler, IRequestHandler<CreateOrderItemCommand, Domain.Order>
{
    public CreateOrderItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Order> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
    {
        var orderItem = _mapper.Map<Domain.OrderItem>(request.OrderItemDTO);
        var order = await _uow.OrderRepository.GetById(orderItem.OrderId);

        Domain.OrderItem existingOrderItem = null;
        foreach (var item in order.OrderItems)
        {
            if (item.ProductId.Equals(orderItem.ProductId))
            {
                existingOrderItem = item;
                existingOrderItem.Amount += orderItem.Amount;
                break;
            }
        }
        
        if (existingOrderItem == null)
        {
            orderItem.Id = Guid.NewGuid().ToString();
            _uow.OrderItemRepository.Create(orderItem);
        }
        else
        {
            _uow.OrderItemRepository.Update(existingOrderItem);
        }

        await _uow.Commit();

        order = await _uow.OrderRepository.GetById(orderItem.OrderId);
        return order;
    }
}