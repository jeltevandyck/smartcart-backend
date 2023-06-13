using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.OrderItem;

public class DeleteOrderItemValidation : AbstractValidationHandler<DeleteOrderItemCommand>
{
    public DeleteOrderItemValidation(IUnitOfWork uow) : base(uow)
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
            .WithMessage("OrderItem not found!");
    }
}