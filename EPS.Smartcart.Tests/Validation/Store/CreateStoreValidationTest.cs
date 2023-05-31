using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Validation.Store;
using EPS.Smartcart.DTO.Store;

namespace EPS.Smartcart.Tests.Validation.Store;

[TestClass]
public class CreateStoreValidationTest : AbstractValidationTest<CreateStoreValidation, CreateStoreCommand>
{
    [TestMethod]
    public async Task CreateStoreValidation()
    {
        var dto = new CreateStoreDTO()
        {
            Name = "Store Name",
            AddressId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new CreateStoreCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateStoreValidationFalse()
    {
        var dto = new CreateStoreDTO()
        {
            Name = "",
            AddressId = ""
        };
        
        var command = new CreateStoreCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}