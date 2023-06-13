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
        var order = await _uow.OrderRepository.GetById(orderItem.OrderId);
        var cart = await _uow.CartRepository.GetById(order.CartId);

        orderItem = _mapper.Map(request.OrderItemDTO, orderItem);
        orderItem = _uow.OrderItemRepository.Update(orderItem);
        
        if (!String.IsNullOrEmpty(cart.GroceryListId))
        {
            var groceryList = await _uow.GroceryListRepository.GetById(cart.GroceryListId);

            foreach (var item in groceryList.GroceryItems)
            {
                if (item.ProductId.Equals(orderItem.ProductId) && orderItem.Amount >= item.Amount)
                {
                    item.IsCollected = true;
                    _uow.GroceryItemRepository.Update(item);
                } else if (item.ProductId.Equals(orderItem.ProductId) && orderItem.Amount < item.Amount)
                {
                    item.IsCollected = false;
                    _uow.GroceryItemRepository.Update(item);
                }
            }
        }
        
        await _uow.Commit();
        return order;
    }
}