using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.DTO.GroceryList;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryList;

public class CreateGroceryListCommand : IRequest<Domain.GroceryList>
{
    public CreateGroceryListDTO GroceryListDTO { get; }
    
    public CreateGroceryListCommand(CreateGroceryListDTO groceryListDTO)
    {
        GroceryListDTO = groceryListDTO;
    }
}

public class CreateGroceryListCommandHandler : AbstractHandler, IRequestHandler<CreateGroceryListCommand, Domain.GroceryList>
{
    public CreateGroceryListCommandHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<Domain.GroceryList> Handle(CreateGroceryListCommand request, CancellationToken cancellationToken)
    {
        var groceryList = _mapper.Map<Domain.GroceryList>(request.GroceryListDTO);

        groceryList.Id = Guid.NewGuid().ToString();

        _uow.GroceryListRepository.Create(groceryList);
        await _uow.Commit();

        return groceryList;
    }
}