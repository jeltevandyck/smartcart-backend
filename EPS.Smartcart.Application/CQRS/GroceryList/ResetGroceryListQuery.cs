using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryItem;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryList;

public class ResetGroceryListQuery : IRequest<Domain.GroceryList>
{
    public ResetGroceryListDTO ResetGroceryListDTO { get; }
    
    public ResetGroceryListQuery(ResetGroceryListDTO resetGroceryListDTO)
    {
        ResetGroceryListDTO = resetGroceryListDTO;
    }
}

public class ResetGroceryListQueryHandler : AbstractHandler, IRequestHandler<ResetGroceryListQuery, Domain.GroceryList>
{
    public ResetGroceryListQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }
    
    public async Task<Domain.GroceryList> Handle(ResetGroceryListQuery request, CancellationToken cancellationToken)
    {
        var groceryList = await _uow.GroceryListRepository.GetById(request.ResetGroceryListDTO.Id);

        foreach (var item in groceryList.GroceryItems)
        {
            item.IsCollected = false;
            _uow.GroceryItemRepository.Update(item);
        }
        
        await _uow.Commit();
        return groceryList;
    }
}