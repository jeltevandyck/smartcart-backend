using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Address;

public class GetAddressByIdQuery : IRequest<Domain.Address>
{
    public string Id { get; }

    public GetAddressByIdQuery(string id)
    {
        Id = id;
    }
}

public class GetAddressByIdQueryHandler : AbstractHandler, IRequestHandler<GetAddressByIdQuery, Domain.Address>
{
    public GetAddressByIdQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Address> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
    {
        var address = await _uow.AddressRepository.GetById(request.Id);
        return address;
    }
}