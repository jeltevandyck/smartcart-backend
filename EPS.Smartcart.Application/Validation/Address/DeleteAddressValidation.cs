using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Address;

public class DeleteAddressValidation : AbstractValidationHandler<DeleteAddressCommand>
{
    public DeleteAddressValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.AddressDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
    }
}