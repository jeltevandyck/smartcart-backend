using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Store;

public class DeleteStoreValidation : AbstractValidationHandler<DeleteStoreCommand>
{
    public DeleteStoreValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.StoreDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
    }
}