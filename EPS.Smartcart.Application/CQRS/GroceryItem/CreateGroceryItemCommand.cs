using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryItem;

public class CreateGroceryItemCommand : IRequest<Domain.GroceryList>
{
    public CreateGroceryItemDTO GroceryItemDTO { get; }
    
    public CreateGroceryItemCommand(CreateGroceryItemDTO groceryItemDTO)
    {
        GroceryItemDTO = groceryItemDTO;
    }
}

public class CreateGroceryItemCommandHandler : AbstractHandler, IRequestHandler<CreateGroceryItemCommand, Domain.GroceryList>
{
    public CreateGroceryItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.GroceryList> Handle(CreateGroceryItemCommand request, CancellationToken cancellationToken)
    {
        var groceryItem = _mapper.Map<Domain.GroceryItem>(request.GroceryItemDTO);

        groceryItem.Id = Guid.NewGuid().ToString();
        groceryItem.IsCollected = false;
        
        _uow.GroceryItemRepository.Create(groceryItem);
        await _uow.Commit();
        
        var groceryList = await _uow.GroceryListRepository.GetById(groceryItem.GroceryListId);
        return groceryList;
    }
}