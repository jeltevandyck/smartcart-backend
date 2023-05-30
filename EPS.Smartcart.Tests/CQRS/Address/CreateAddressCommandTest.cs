using AutoMapper;
using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Application.Mappers;
using EPS.Smartcart.DTO.Address;
using EPS.Smartcart.Tests.Mocks;

namespace EPS.Smartcart.Tests.CQRS;

[TestClass]
public class CreateAddressCommandTest : AbstractCQRSHelper<CreateAddressCommandHandler>
{

    [TestMethod]
    public async Task CreateAddress()
    {
        var dto = new CreateAddressDTO()
        {
            Street = "Pelikaanstraat",
            Number = "1",
            Extra = "Bus 1",
            City = "Antwerp",
            Country = "Belgium",
            PostalCode = "2000",
            State = "Antwerp"
        };

        var command = new CreateAddressCommand(dto);

        var result = await _handler.Handle(command, CancellationToken.None);

        Assert.IsNotNull(result);
    }
}