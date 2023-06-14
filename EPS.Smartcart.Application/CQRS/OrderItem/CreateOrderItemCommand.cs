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

        var existingOrderItems = await _uow.OrderItemRepository.Query(x => x.OrderId.Equals(orderItem.OrderId) && x.ProductId.Equals(orderItem.ProductId));

        if (existingOrderItems.Count == 0)
        {
            orderItem.Id = Guid.NewGuid().ToString();
            _uow.OrderItemRepository.Create(orderItem);
        }
        else
        {
            var item = existingOrderItems[0];
            item.Amount += orderItem.Amount;
            orderItem = _uow.OrderItemRepository.Update(item);
        }
        
        await _uow.Commit();

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
            }
        }
        
        await _uow.Commit();

        order = await _uow.OrderRepository.GetById(orderItem.OrderId);
        return order;
    }
}