using EPS.Smartcart.Application.CQRS.GroceryItem;
using EPS.Smartcart.Application.CQRS.GroceryList;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.GroceryItem;
using EPS.Smartcart.DTO.GroceryList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

public class GroceryListController : AbstractController
{
    public GroceryListController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] GroceryListFilter groceryListFilter, [FromQuery] PaginationFilter<GroceryList> paginationFilter)
    {
        var groceryLists = await _mediator.Send(new GetAllGroceryListsQuery(groceryListFilter, paginationFilter));
        return Ok(groceryLists);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var groceryList = await _mediator.Send(new GetGroceryListByIdQuery(id));
        return Ok(groceryList);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateGroceryListDTO groceryList)
    {
        var result = await _mediator.Send(new CreateGroceryListCommand(groceryList));
        return Ok(result);
    }
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateGroceryListDTO groceryList)
    {
        var result = await _mediator.Send(new UpdateGroceryListCommand(groceryList));
        return Ok(result);
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] DeleteGroceryListDTO groceryList)
    {
        var result = await _mediator.Send(new DeleteGroceryListCommand(groceryList));
        return Ok(result);
    }
    
    [HttpPost("product")]
    public async Task<IActionResult> AddItem([FromBody] CreateGroceryItemDTO item)
    {
        var result = await _mediator.Send(new CreateGroceryItemCommand(item));
        return Ok(result);
    }
    
    [HttpPut("product")]
    public async Task<IActionResult> UpdateItem([FromBody] UpdateGroceryItemDTO item)
    {
        var result = await _mediator.Send(new UpdateGroceryItemCommand(item));
        return Ok(result);
    }
    
    [HttpDelete("product")]
    public async Task<IActionResult> DeleteItem([FromQuery] DeleteGroceryItemDTO item)
    {
        var result = await _mediator.Send(new DeleteGroceryItemCommand(item));
        return Ok(result);
    }

}