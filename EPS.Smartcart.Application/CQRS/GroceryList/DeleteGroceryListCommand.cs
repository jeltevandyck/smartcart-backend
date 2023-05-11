using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryList;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryList;

public class DeleteGroceryListCommand : IRequest<Domain.GroceryList>
{
    public DeleteGroceryListDTO GroceryListDTO { get; }
    
    public DeleteGroceryListCommand(DeleteGroceryListDTO groceryListDTO)
    {
        GroceryListDTO = groceryListDTO;
    }
}

public class DeleteGroceryListCommandHandler : AbstractHandler, IRequestHandler<DeleteGroceryListCommand, Domain.GroceryList>
{
    public DeleteGroceryListCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.GroceryList> Handle(DeleteGroceryListCommand request, CancellationToken cancellationToken)
    {
        var groceryList = await _uow.GroceryListRepository.GetById(request.GroceryListDTO.Id);
        
        _uow.GroceryListRepository.Delete(groceryList);
        await _uow.Commit();

        return groceryList;
    }
}