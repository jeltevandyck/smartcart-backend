using EPS.Smartcart.Application.CQRS.Address;
using EPS.Smartcart.Application.Validation.Address;
using EPS.Smartcart.DTO.Address;

namespace EPS.Smartcart.Tests.Validation.Address;

[TestClass]
public class DeleteAddressValidationTest : AbstractValidationTest<DeleteAddressValidation, DeleteAddressCommand>
{
 
    [TestMethod]
    public async Task DeleteAddressValidation()
    {
        var address = new DeleteAddressDTO
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteAddressCommand(address);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteAddressValidationFalse()
    {
        var address = new DeleteAddressDTO
        {
            Id = ""
        };
        
        var command = new DeleteAddressCommand(address);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}