using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.OrderItem;

public class UpdateOrderItemValidation : AbstractValidationHandler<UpdateOrderItemCommand>
{
    public UpdateOrderItemValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.OrderItemDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
        
        RuleFor(x => x.OrderItemDTO.Id)
            .MustAsync(async (id, cancellationToken) =>
            {
                var orderItem = await _uow.OrderItemRepository.GetById(id);
                return orderItem != null;
            })
            .WithMessage("OrderItem does not exist!");

        RuleFor(x => x.OrderItemDTO.ProductId)
            .MustAsync(async (productId, cancellation) =>
            {
                var product = await _uow.ProductRepository.GetById(productId);
                return product != null;
            })
            .WithMessage("Product does not exist!");

        RuleFor(x => x.OrderItemDTO.OrderId)
            .MustAsync(async (orderId, cancellation) =>
            {
                var order = await _uow.OrderRepository.GetById(orderId);
                return order != null;
            })
            .WithMessage("Order does not exist!");
    }
}