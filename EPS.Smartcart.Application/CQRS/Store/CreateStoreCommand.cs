using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Store;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Store;

public class CreateStoreCommand : IRequest<Domain.Store>
{
    public CreateStoreDTO StoreDTO { get; }
    
    public CreateStoreCommand(CreateStoreDTO storeDTO)
    {
        StoreDTO = storeDTO;
    }
}

public class CreateStoreCommandHandler : AbstractHandler, IRequestHandler<CreateStoreCommand, Domain.Store>
{
    public CreateStoreCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Store> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
    {
        var store = _mapper.Map<Domain.Store>(request.StoreDTO);
        store.Id = Guid.NewGuid().ToString();
        _uow.StoreRepository.Create(store);
        await _uow.Commit();

        return store;
    }
}