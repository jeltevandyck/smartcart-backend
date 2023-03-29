using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;
using EPS.Smartcart.DTO.Address;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EPS.Smartcart.API.Controllers;

public class AddressController : AbstractController
{
    public AddressController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] AddressFilter addressFilter,
        [FromQuery] PaginationFilter<Address> paginationFilter)
    {
        var addresses = await _mediator.Send(new GetAllAddressesQuery(addressFilter, paginationFilter));
        return Ok(addresses);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var address = await _mediator.Send(new GetAddressByIdQuery(id));
        return Ok(address);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateAddressDTO address)
    {
        var result = await _mediator.Send(new CreateAddressCommand(address));
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Put([FromBody] UpdateAddressDTO address)
    {
        var result = await _mediator.Send(new UpdateAddressCommand(address));
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteAddressDTO address)
    {
        var result = await _mediator.Send(new DeleteAddressCommand(address));
        return Ok(result);
    }
}