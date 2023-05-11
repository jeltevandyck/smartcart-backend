using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Order;

public class DeleteOrderValidation : AbstractValidationHandler<DeleteOrderCommand>
{
    public DeleteOrderValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.OrderDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.OrderDTO.Id)
            .MustAsync(async (x, id, cancellationToken) =>
            {
                var order = await uow.OrderRepository.GetById(id);
                return order != null;
            })
            .WithMessage("Order does not exist!");
    }
}