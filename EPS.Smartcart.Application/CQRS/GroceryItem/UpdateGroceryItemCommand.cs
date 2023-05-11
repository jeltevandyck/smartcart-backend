using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryItem;

public class UpdateGroceryItemCommand : IRequest<Domain.GroceryItem>
{
    public UpdateGroceryItemDTO GroceryItemDTO { get; }
    
    public UpdateGroceryItemCommand(UpdateGroceryItemDTO groceryItemDTO)
    {
        GroceryItemDTO = groceryItemDTO;
    }
}

public class UpdateGroceryItemCommandHandler : AbstractHandler, IRequestHandler<UpdateGroceryItemCommand, Domain.GroceryItem>
{
    public UpdateGroceryItemCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.GroceryItem> Handle(UpdateGroceryItemCommand request, CancellationToken cancellationToken)
    {
        var groceryItem = await _uow.GroceryItemRepository.GetById(request.GroceryItemDTO.Id);
        
        groceryItem = _mapper.Map(request.GroceryItemDTO, groceryItem);
        
        _uow.GroceryItemRepository.Update(groceryItem);
        await _uow.Commit();

        return groceryItem;
    }
}