using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Store;

public class CreateStoreValidation : AbstractValidationHandler<CreateStoreCommand>
{
    public CreateStoreValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.StoreDTO.Name)
            .NotEmpty()
            .NotNull()
            .WithMessage("Name is required!");
        
        RuleFor(x => x.StoreDTO.AddressId)
            .NotEmpty()
            .NotNull()
            .WithMessage("AddressId is required!");

        RuleFor(x => x.StoreDTO.AddressId)
            .MustAsync(async (x, addressId, cancellationToken) =>
            {
                var address = await uow.AddressRepository.GetById(addressId);
                return address != null;
            })
            .WithMessage("AddressId is invalid!");
    }
}