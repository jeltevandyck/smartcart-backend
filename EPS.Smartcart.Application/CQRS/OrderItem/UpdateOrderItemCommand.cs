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

        orderItem = _mapper.Map(request.OrderItemDTO, orderItem);
        orderItem = _uow.OrderItemRepository.Update(orderItem);
        
        var cart = await _uow.CartRepository.GetById(order.CartId);
        if (!String.IsNullOrEmpty(cart.GroceryListId))
        {
            var existingGroceryItems = await _uow.GroceryItemRepository.Query(x => x.GroceryListId == cart.GroceryListId && x.ProductId.Equals(orderItem.ProductId));
            if (existingGroceryItems.Count == 1)
            {
                var groceryItem = existingGroceryItems[0];
                
                if (orderItem.Amount >= groceryItem.Amount)
                {
                    groceryItem.IsCollected = true;
                    _uow.GroceryItemRepository.Update(groceryItem);
                }
                else
                {
                    groceryItem.IsCollected = false;
                    _uow.GroceryItemRepository.Update(groceryItem);
                }
            }
        }
        await _uow.Commit();

        order = await _uow.OrderRepository.GetById(orderItem.OrderId);
        await _uow.Commit();
        
        return order;
    }
}