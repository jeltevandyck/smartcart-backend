using System.Data;
using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.OrderItem;

public class CreateOrderItemValidation : AbstractValidationHandler<CreateOrderItemCommand>
{
    public CreateOrderItemValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.OrderItemDTO.Amount)
            .NotEmpty()
            .NotNull()
            .WithMessage("Amount is required!");

        RuleFor(x => x.OrderItemDTO.OrderId)
            .NotEmpty()
            .NotNull()
            .WithMessage("OrderId is required!");

        RuleFor(x => x.OrderItemDTO.ProductId)
            .NotEmpty()
            .NotNull()
            .WithMessage("ProductId is required!");
    }
}