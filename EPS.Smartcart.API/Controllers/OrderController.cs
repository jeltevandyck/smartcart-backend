using EPS.Smartcart.Application.CQRS.Order;
using EPS.Smartcart.Application.CQRS.OrderItem;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Order;
using EPS.Smartcart.DTO.OrderItem;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

public class OrderController : AbstractController
{
    public OrderController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] OrderFilter entityFilter, [FromQuery] PaginationFilter<Order> pageFilter)
    {
        var orders = await _mediator.Send(new GetAllOrdersQuery(entityFilter, pageFilter));
        return Ok(orders);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var order = await _mediator.Send(new GetOrderByIdQuery(id));
        return Ok(order);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateOrderDTO order)
    {
        var result = await _mediator.Send(new CreateOrderCommand(order));
        return Ok(result);
    }
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateOrderDTO order)
    {
        var result = await _mediator.Send(new UpdateOrderCommand(order));
        return Ok(result);
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteOrderDTO order)
    {
        var result = await _mediator.Send(new DeleteOrderCommand(order));
        return Ok(result);
    }
    
    [HttpPost("product")]
    public async Task<IActionResult> AddItem([FromBody] CreateOrderItemDTO item)
    {
        var result = await _mediator.Send(new CreateOrderItemCommand(item));
        return Ok(result);
    }
    
    [HttpPut("product")]
    public async Task<IActionResult> UpdateItem([FromBody] UpdateOrderItemDTO item)
    {
        var result = await _mediator.Send(new UpdateOrderItemCommand(item));
        return Ok(result);
    }
    
    [HttpDelete("product")]
    public async Task<IActionResult> RemoveItem([FromBody] DeleteOrderItemDTO item)
    {
        var result = await _mediator.Send(new DeleteOrderItemCommand(item));
        return Ok(result);
    }
}