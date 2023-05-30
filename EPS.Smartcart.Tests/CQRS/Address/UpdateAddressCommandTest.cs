using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.DTO.Address;

namespace EPS.Smartcart.Tests.CQRS;

[TestClass]
public class UpdateAddressCommandTest : AbstractCQRSHelper<UpdateAddressCommandHandler>
{
    [TestMethod]
    public async Task UpdateAddress()
    {
        var dto = new UpdateAddressDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Street = "Rua 1",
            Number = "1",
            Extra = "Casa 1",
            City = "Cidade 1",
            PostalCode = "Codigo Postal 1",
            Country = "Pais 1",
            State = "Estado 1"
        };
        
        var command = new UpdateAddressCommand(dto);
        
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
        Assert.AreEqual("c0a80101-0000-0000-0000-000000000001", result.Id);
        Assert.AreEqual("Rua 1", result.Street);
        Assert.AreEqual("1", result.Number);
        Assert.AreEqual("Casa 1", result.Extra);
        Assert.AreEqual("Cidade 1", result.City);
        Assert.AreEqual("Codigo Postal 1", result.PostalCode);
        Assert.AreEqual("Pais 1", result.Country);
        Assert.AreEqual("Estado 1", result.State);
    }

}