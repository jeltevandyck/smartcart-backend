using AutoMapper;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Address;

public class GetAllAddressesQuery : IRequest<IEnumerable<Domain.Address>>
{
    public AddressFilter EntityFilter { get; }
    public PaginationFilter<Domain.Address> PageFilter { get; }

    public GetAllAddressesQuery(AddressFilter entityFilter, PaginationFilter<Domain.Address> pageFilter)
    {
        EntityFilter = entityFilter;
        PageFilter = pageFilter;
    }
}

public class GetAllAddressesQueryHandler : AbstractHandler, IRequestHandler<GetAllAddressesQuery, IEnumerable<Domain.Address>>
{
    public GetAllAddressesQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<IEnumerable<Domain.Address>> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
    {
        var addresses = await _uow.AddressRepository.GetAll(request.EntityFilter, request.PageFilter);
        return addresses;
    }
}