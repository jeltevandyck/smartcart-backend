using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.Store;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.Store;

public class DeleteStoreCommand : IRequest<Domain.Store>
{
    public DeleteStoreDTO StoreDTO { get; }
    
    public DeleteStoreCommand(DeleteStoreDTO storeDTO)
    {
        StoreDTO = storeDTO;
    }
}

public class DeleteStoreCommandHandler : AbstractHandler, IRequestHandler<DeleteStoreCommand, Domain.Store>
{
    public DeleteStoreCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.Store> Handle(DeleteStoreCommand request, CancellationToken cancellationToken)
    {
        var store = await _uow.StoreRepository.GetById(request.StoreDTO.Id);
        
        store = _mapper.Map(request.StoreDTO, store);
        store = _uow.StoreRepository.Delete(store);
        await _uow.Commit();
        
        return store;
    }
}