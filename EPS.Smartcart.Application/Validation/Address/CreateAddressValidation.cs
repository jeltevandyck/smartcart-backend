using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Address;

public class CreateAddressValidation : AbstractValidationHandler<CreateAddressCommand>
{
    public CreateAddressValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.AddressDTO.Street)
            .NotEmpty()
            .NotNull()
            .WithMessage("Street is required!");
        
        RuleFor(x => x.AddressDTO.Number)
            .NotEmpty()
            .NotNull()
            .WithMessage("Number is required!");
        
        RuleFor(x => x.AddressDTO.PostalCode)
            .NotEmpty()
            .NotNull()
            .WithMessage("PostalCode is required!");
        
        RuleFor(x => x.AddressDTO.State)
            .NotEmpty()
            .NotNull()
            .WithMessage("City is required!");
        
        RuleFor(x => x.AddressDTO.Country)
            .NotEmpty()
            .NotNull()
            .WithMessage("Country is required!");
    }
}