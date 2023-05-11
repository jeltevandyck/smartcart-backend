using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.Application.Interfaces;
using FluentValidation;

namespace EPS.Smartcart.Application.Validation.User;

public class CreateUserValidation : AbstractValidationHandler<CreateUserCommand>
{
    public CreateUserValidation(IUnitOfWork uow) : base(uow)
    {
        RuleFor(x => x.UserDTO.Email)
            .NotEmpty()
            .NotNull()
            .WithMessage("Email is required!");
        
        RuleFor(x => x.UserDTO.BirthDate)
            .NotEmpty()
            .NotNull()
            .WithMessage("Birth date is required!");
        
        RuleFor(x => x.UserDTO.FirstName)
            .NotEmpty()
            .NotNull()
            .WithMessage("First name is required!");
        
        RuleFor(x => x.UserDTO.LastName)
            .NotEmpty()
            .NotNull()
            .WithMessage("Last name is required!");
        
    }
}