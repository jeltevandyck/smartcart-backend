using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.User;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.User;

public class UpdateUserCommand : IRequest<Domain.User>
{
    public UpdateUserDTO UserDTO { get; }
    
    public UpdateUserCommand(UpdateUserDTO userDTO)
    {
        UserDTO = userDTO;
    }
}

public class UpdateUserCommandHandler : AbstractHandler, IRequestHandler<UpdateUserCommand, Domain.User>
{
    public UpdateUserCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _uow.UserRepository.GetById(request.UserDTO.Id);
        
        user = _mapper.Map(request.UserDTO, user);
        user = _uow.UserRepository.Update(user);
        await _uow.Commit();
        
        return user;
    }
}