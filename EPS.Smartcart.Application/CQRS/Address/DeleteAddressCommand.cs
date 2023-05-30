using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Address;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Address;

public class DeleteAddressCommand : IRequest<Domain.Address>
{
    public DeleteAddressDTO AddressDTO { get; }

    public DeleteAddressCommand(DeleteAddressDTO addressDto)
    {
        AddressDTO = addressDto;
    }
}

public class DeleteAddressCommandHandler : AbstractHandler, IRequestHandler<DeleteAddressCommand, Domain.Address>
{
    public DeleteAddressCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Address> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
    {
        var address = await _uow.AddressRepository.GetById(request.AddressDTO.Id);

        address = _mapper.Map(request.AddressDTO, address);
        _uow.AddressRepository.Delete(address);
        await _uow.Commit();

        return address;
    }
}