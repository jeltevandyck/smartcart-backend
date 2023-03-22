using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Store;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Store;

public class UpdateStoreCommand : IRequest<Domain.Store>
{
    public UpdateStoreDTO StoreDTO { get; }
    
    public UpdateStoreCommand(UpdateStoreDTO storeDTO)
    {
        StoreDTO = storeDTO;
    }
}

public class UpdateStoreCommandHandler : AbstractHandler, IRequestHandler<UpdateStoreCommand, Domain.Store>
{
    public UpdateStoreCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Store> Handle(UpdateStoreCommand request, CancellationToken cancellationToken)
    {
        var store = await _uow.StoreRepository.GetById(request.StoreDTO.Id);
        
        store = _mapper.Map(request.StoreDTO, store);
        
        store = _uow.StoreRepository.Update(store);
        await _uow.Commit();
        
        return store;   
    }
}