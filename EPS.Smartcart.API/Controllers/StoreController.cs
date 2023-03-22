using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Store;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

public class StoreController : AbstractController
{
    public StoreController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] StoreFilter storeFilter, [FromQuery] PaginationFilter<Store> paginationFilter)
    {
        var stores = await _mediator.Send(new GetAllStoresQuery(storeFilter, paginationFilter));
        return Ok(stores);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var store = await _mediator.Send(new GetStoreByIdQuery(id));
        return Ok(store);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateStoreDTO store)
    {
        var result = await _mediator.Send(new CreateStoreCommand(store));
        return Ok(result);
    }
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateStoreDTO store)
    {
        var result = await _mediator.Send(new UpdateStoreCommand(store));
        return Ok(result);
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStoreDTO store)
    {
        var result = await _mediator.Send(new DeleteStoreCommand(store));
        return Ok(result);
    }
}