using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryList;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryList;

public class UpdateGroceryListCommand : IRequest<Domain.GroceryList>
{
    public UpdateGroceryListDTO GroceryListDTO { get; }
    
    public UpdateGroceryListCommand(UpdateGroceryListDTO groceryListDTO)
    {
        GroceryListDTO = groceryListDTO;
    }
}

public class UpdateGroceryListCommandHandler : AbstractHandler, IRequestHandler<UpdateGroceryListCommand, Domain.GroceryList>
{
    public UpdateGroceryListCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.GroceryList> Handle(UpdateGroceryListCommand request, CancellationToken cancellationToken)
    {
        var groceryList = await _uow.GroceryListRepository.GetById(request.GroceryListDTO.Id);
        
        groceryList = _mapper.Map(request.GroceryListDTO, groceryList);
        
        _uow.GroceryListRepository.Update(groceryList);
        await _uow.Commit();

        return groceryList;
    }
}