using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryItem;

public class DeleteGroceryItemCommand : IRequest<Domain.GroceryList>
{
    public DeleteGroceryItemDTO GroceryItemDTO { get; }
    
    public DeleteGroceryItemCommand(DeleteGroceryItemDTO groceryItemDTO)
    {
        GroceryItemDTO = groceryItemDTO;
    }
}

public class DeleteGroceryItemCommandHandler : AbstractHandler, IRequestHandler<DeleteGroceryItemCommand, Domain.GroceryList>
{
    public DeleteGroceryItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.GroceryList> Handle(DeleteGroceryItemCommand request, CancellationToken cancellationToken)
    {
        var groceryItem = await _uow.GroceryItemRepository.GetById(request.GroceryItemDTO.Id);
        
        _uow.GroceryItemRepository.Delete(groceryItem);
        await _uow.Commit();
        
        var groceryList = await _uow.GroceryListRepository.GetById(groceryItem.GroceryListId);
        return groceryList;
    }
}