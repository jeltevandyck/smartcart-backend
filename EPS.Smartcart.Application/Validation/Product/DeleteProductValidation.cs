using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Product;

public class DeleteProductValidation : AbstractValidationHandler<DeleteProductCommand>
{
    public DeleteProductValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.ProductDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
    }
}