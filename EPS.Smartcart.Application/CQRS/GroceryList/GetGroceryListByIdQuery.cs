using AutoMapper;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryList;

public class GetGroceryListByIdQuery : IRequest<Domain.GroceryList>
{
    public string Id { get; set; }

    public GetGroceryListByIdQuery(string id)
    {
        Id = id;
    }
}

public class GetGroceryListByIdQueryHandler : AbstractHandler, IRequestHandler<GetGroceryListByIdQuery, Domain.GroceryList>
{
    public GetGroceryListByIdQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }
    
    public async Task<Domain.GroceryList> Handle(GetGroceryListByIdQuery request, CancellationToken cancellationToken)
    {
        var groceryList = await _uow.GroceryListRepository.GetById(request.Id);
        return groceryList;
    }
}

