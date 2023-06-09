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

        orderItem.Id = Guid.NewGuid().ToString();
        
        _uow.OrderItemRepository.Create(orderItem);
        await _uow.Commit();
        
        var order = await _uow.OrderRepository.GetById(orderItem.OrderId);
        return order;
    }
}