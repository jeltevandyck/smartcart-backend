using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryItem;

public class DeleteGroceryItemCommand : IRequest<Domain.GroceryItem>
{
    public DeleteGroceryItemDTO GroceryItemDTO { get; }
    
    public DeleteGroceryItemCommand(DeleteGroceryItemDTO groceryItemDTO)
    {
        GroceryItemDTO = groceryItemDTO;
    }
}

public class DeleteGroceryItemCommandHandler : AbstractHandler, IRequestHandler<DeleteGroceryItemCommand, Domain.GroceryItem>
{
    public DeleteGroceryItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.GroceryItem> Handle(DeleteGroceryItemCommand request, CancellationToken cancellationToken)
    {
        var groceryItem = await _uow.GroceryItemRepository.GetById(request.GroceryItemDTO.Id);
        
        _uow.GroceryItemRepository.Delete(groceryItem);
        await _uow.Commit();

        return groceryItem;
    }
}