using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.User;

public class UpdateUserValidation : AbstractValidationHandler<UpdateUserCommand>
{
    public UpdateUserValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.UserDTO.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Id is required!");
        
        
    }
}