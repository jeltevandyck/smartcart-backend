using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Address;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Address;

public class UpdateAddressCommand : IRequest<Domain.Address>
{
    public UpdateAddressDTO AddressDTO { get; set; }

    public UpdateAddressCommand(UpdateAddressDTO addressDto)
    {
        AddressDTO = addressDto;
    }
}

public class UpdateAddressCommandHandler : AbstractHandler, IRequestHandler<UpdateAddressCommand, Domain.Address>
{
    public UpdateAddressCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Address> Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = await _uow.AddressRepository.GetById(request.AddressDTO.Id);

        address = _mapper.Map(request.AddressDTO, address);
        address = _uow.AddressRepository.Update(address);
        await _uow.Commit();
        
        return address;
    }
}