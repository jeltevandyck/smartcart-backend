using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Validation.Address;
using EPS.Smartcart.DTO.Address;

namespace EPS.Smartcart.Tests.Validation.Address;

[TestClass]
public class UpdateAddressValidationTest : AbstractValidationTest<UpdateAddressValidation, UpdateAddressCommand>
{
    [TestMethod]
    public async Task UpdateAddressValidation()
    {
        var address = new UpdateAddressDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Street = "Rua 1",
            Number = "123",
            Extra = "Casa 1",
            PostalCode = "12345678",
            State = "SP",
            City = "São Paulo",
            Country = "Brasil"
        };
        
        var command = new UpdateAddressCommand(address);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task UpdateAddressValidationFalse()
    {
        var address = new UpdateAddressDTO
        {
            Id = "",
            Street = "",
            Number = "123",
            Extra = "Casa 1",
            PostalCode = "12345678",
            State = "SP",
            City = "São Paulo",
            Country = "Brasil"
        };
        
        var command = new UpdateAddressCommand(address);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}