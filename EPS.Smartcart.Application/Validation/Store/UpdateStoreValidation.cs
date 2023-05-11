using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.Store;

public class UpdateStoreValidation : AbstractValidationHandler<UpdateStoreCommand>
{
    public UpdateStoreValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.StoreDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");

        RuleFor(x => x.StoreDTO.AddressId)
            .MustAsync(async (x, addressId, cancellationToken) =>
            {
                var address = await uow.AddressRepository.GetById(addressId);
                return address != null;
            })
            .WithMessage("AddressId is invalid!");
    }
}