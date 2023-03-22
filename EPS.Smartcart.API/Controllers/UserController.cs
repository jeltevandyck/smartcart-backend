using EPS.Smartcart.Application.CQRS.User;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

public class UserController : AbstractController
{
    public UserController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] UserFilter userFilter, [FromQuery] PaginationFilter<User> paginationFilter)
    {
        var users = await _mediator.Send(new GetAllUsersQuery(userFilter, paginationFilter));
        return Ok(users);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user = await _mediator.Send(new GetUserByIdQuery(id));
        return Ok(user);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateUserDTO user)
    {
        var result = await _mediator.Send(new CreateUserCommand(user));
        return Ok(result);
    }
    
    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateUserDTO user)
    {
        var result = await _mediator.Send(new UpdateUserCommand(user));
        return Ok(result);
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUserDTO user)
    {
        var result = await _mediator.Send(new DeleteUserCommand(user));
        return Ok(result);
    }
}