using AutoMapper;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.User;

public class GetAllUsersCommand : IRequest<IEnumerable<Domain.User>>
{
    public UserFilter EntityFilter { get; }
    public PaginationFilter<Domain.User> PageFilter { get; }
    
    public GetAllUsersCommand(UserFilter entityFilter, PaginationFilter<Domain.User> pageFilter)
    {
        EntityFilter = entityFilter;
        PageFilter = pageFilter;
    }
}

public class GetAllUsersCommandHandler : AbstractHandler, IRequestHandler<GetAllUsersCommand, IEnumerable<Domain.User>>
{
    public GetAllUsersCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<IEnumerable<Domain.User>> Handle(GetAllUsersCommand request, CancellationToken cancellationToken)
    {
        var users = await _uow.UserRepository.GetAll(request.EntityFilter, request.PageFilter);
        return users;
    }
}