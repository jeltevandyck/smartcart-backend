using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.User;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.User;

public class CreateUserCommand : IRequest<Domain.User>
{
    public CreateUserDTO UserDTO { get; }
    
    public CreateUserCommand(CreateUserDTO userDTO)
    {
        UserDTO = userDTO;
    }
}

public class CreateUserCommandHandler : AbstractHandler, IRequestHandler<CreateUserCommand, Domain.User>
{
    public CreateUserCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<Domain.User>(request.UserDTO);

        user.Id = Guid.NewGuid().ToString();
        
        _uow.UserRepository.Create(user);
        await _uow.Commit();

        return user;
    }
}