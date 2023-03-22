using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Address;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Address;

public class CreateAddressCommand : IRequest<Domain.Address>
{
    public CreateAddressDTO AddressDTO { get; set; }

    public CreateAddressCommand(CreateAddressDTO addressDto)
    {
        AddressDTO = addressDto;
    }
}

public class CreateAddressCommandHandler : AbstractHandler, IRequestHandler<CreateAddressCommand, Domain.Address>
{
    public CreateAddressCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Address> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = _mapper.Map<Domain.Address>(request.AddressDTO);

        address.Id = Guid.NewGuid().ToString();

        _uow.AddressRepository.Create(address);
        await _uow.Commit();

        return address;
    }
}