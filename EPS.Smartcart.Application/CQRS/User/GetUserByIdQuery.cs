using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.User;

public class GetUserByIdQuery : IRequest<Domain.User>
{
    public string Id { get; }
    
    public GetUserByIdQuery(string id)
    {
        Id = id;
    }
}

public class GetUserByIdQueryHandler : AbstractHandler, IRequestHandler<GetUserByIdQuery, Domain.User>
{
    public GetUserByIdQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _uow.UserRepository.GetById(request.Id);
        return user;
    }
}