using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Validation.Store;
using EPS.Smartcart.DTO.Store;

namespace EPS.Smartcart.Tests.Validation.Store;

[TestClass]
public class UpdateStoreValidationTest : AbstractValidationTest<UpdateStoreValidation, UpdateStoreCommand>
{
    [TestMethod]
    public async Task UpdateStoreValidation()
    {
        var dto = new UpdateStoreDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            Name = "Store Name",
            AddressId = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new UpdateStoreCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task UpdateStoreValidationFalse()
    {
        var dto = new UpdateStoreDTO()
        {
            Id = "",
            Name = "",
            AddressId = ""
        };
        
        var command = new UpdateStoreCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}