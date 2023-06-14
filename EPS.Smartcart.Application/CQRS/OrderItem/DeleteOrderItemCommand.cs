using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.OrderItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.OrderItem;

public class DeleteOrderItemCommand : IRequest<Domain.Order>
{
    public DeleteOrderItemDTO OrderItemDTO { get; }
    
    public DeleteOrderItemCommand(DeleteOrderItemDTO orderItemDTO)
    {
        OrderItemDTO = orderItemDTO;
    }
}

public class DeleteOrderItemCommandHandler : AbstractHandler, IRequestHandler<DeleteOrderItemCommand, Domain.Order>
{
    public DeleteOrderItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Order> Handle(DeleteOrderItemCommand request, CancellationToken cancellationToken)
    {
        var orderItem = await _uow.OrderItemRepository.GetById(request.OrderItemDTO.Id);
        var order = await _uow.OrderRepository.GetById(orderItem.OrderId);
        var cart = await _uow.CartRepository.GetById(order.CartId);

        if (!String.IsNullOrEmpty(cart.GroceryListId))
        {
            var existingGroceryItems = await _uow.GroceryItemRepository.Query(x => x.GroceryListId == cart.GroceryListId && x.ProductId.Equals(orderItem.ProductId));
            if (existingGroceryItems.Count == 1)
            {
                var groceryItem = existingGroceryItems[0];
                
                groceryItem.IsCollected = false;
                _uow.GroceryItemRepository.Update(groceryItem);
            }
        }
        
        await _uow.Commit();
        
        _uow.OrderItemRepository.Delete(orderItem);
        await _uow.Commit();
        
        return order;
    }
}