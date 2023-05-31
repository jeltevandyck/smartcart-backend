using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Validation.Address;
using EPS.Smartcart.DTO.Address;

namespace EPS.Smartcart.Tests.Validation.Address;

[TestClass]
public class CreateAddressValidationTest : AbstractValidationTest<CreateAddressValidation, CreateAddressCommand>
{
    [TestMethod]
    public async Task CreateAddressValidation()
    {
        var address = new CreateAddressDTO
        {
            Street = "Rua 1",
            Number = "123",
            Extra = "Casa 1",
            PostalCode = "12345678",
            State = "SP",
            City = "São Paulo",
            Country = "Brasil"
        };
        
        var command = new CreateAddressCommand(address);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateAddressValidationFalse()
    {
        var address = new CreateAddressDTO
        {
            Street = "",
            Number = "123",
            Extra = "Casa 1",
            PostalCode = "12345678",
            State = "SP",
            City = "São Paulo",
            Country = "Brasil"
        };
        
        var command = new CreateAddressCommand(address);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}