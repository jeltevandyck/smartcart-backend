using System.Collections;
using AutoMapper;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using MediatR;

namespace EPS.Smartcart.Application.CQRS.GroceryList;

public class GetAllGroceryListsQuery : IRequest<IEnumerable<Domain.GroceryList>>
{
    public GroceryListFilter EntityFilter { get; }
    public PaginationFilter<Domain.GroceryList> PageFilter { get; }

    public GetAllGroceryListsQuery(GroceryListFilter entityFilter, PaginationFilter<Domain.GroceryList> pageFilter)
    {
        EntityFilter = entityFilter;
        PageFilter = pageFilter;
    }
}

public class GetAllGroceryListsQueryHandler : AbstractHandler, IRequestHandler<GetAllGroceryListsQuery, IEnumerable<Domain.GroceryList>>
{
    public GetAllGroceryListsQueryHandler(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
    {
    }

    public async Task<IEnumerable<Domain.GroceryList>> Handle(GetAllGroceryListsQuery request, CancellationToken cancellationToken)
    {
        var groceryLists = await _uow.GroceryListRepository.GetAll(request.EntityFilter, request.PageFilter);
        return groceryLists;
    }
}