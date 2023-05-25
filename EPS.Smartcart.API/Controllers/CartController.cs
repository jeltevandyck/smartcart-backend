using EPS.Smartcart.Application.CQRS;
using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Cart;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

public class CartController : AbstractController
{
    public CartController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] CartFilter cartFilter,
        [FromQuery] PaginationFilter<Cart> paginationFilter)
    {
        var carts = await _mediator.Send(new GetAllCartsQuery(cartFilter, paginationFilter));
        return Ok(carts);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var address = await _mediator.Send(new GetCartByIdQuery(id));
        return Ok(address);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateCartDTO cart)
    {
        var result = await _mediator.Send(new CreateCartCommand(cart));
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateCartDTO cart)
    { 
        var result = await _mediator.Send(new UpdateCartCommand(cart));
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteCartDTO cart)
    {
        var result = await _mediator.Send(new DeleteCartCommand(cart));
        return Ok(result);
    }
    
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterCartDTO cart)
    {
        var result = await _mediator.Send(new RegisterCartQuery(cart));
        return Ok(result);
    }
    
    [HttpPost("unregister")]
    public async Task<IActionResult> Unregister([FromBody] UnregisterCartDTO cart)
    {
        var result = await _mediator.Send(new UnregisterCartQuery(cart));
        return Ok(result);
    }
}