using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.User;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.User;

public class DeleteUserCommand : IRequest<Domain.User>
{
    public DeleteUserDTO UserDTO { get; }
    
    public DeleteUserCommand(DeleteUserDTO userDTO)
    {
        UserDTO = userDTO;
    }
}

public class DeleteUserCommandHandler : AbstractHandler, IRequestHandler<DeleteUserCommand, Domain.User>
{
    public DeleteUserCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.User> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        var user = await _uow.UserRepository.GetById(request.UserDTO.Id);
        
        user = _mapper.Map(request.UserDTO, user);
        user = _uow.UserRepository.Delete(user);
        await _uow.Commit();

        return user;
    }
}