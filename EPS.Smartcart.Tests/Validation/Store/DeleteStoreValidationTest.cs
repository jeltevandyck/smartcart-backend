using EPS.Smartcart.Application.CQRS.Store;
using EPS.Smartcart.Application.Validation.Store;
using EPS.Smartcart.DTO.Store;

namespace EPS.Smartcart.Tests.Validation.Store;

[TestClass]
public class DeleteStoreValidationTest : AbstractValidationTest<DeleteStoreValidation, DeleteStoreCommand>
{
    [TestMethod]
    public async Task DeleteStoreValidation()
    {
        var dto = new DeleteStoreDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteStoreCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task DeleteStoreValidationFalse()
    {
        var dto = new DeleteStoreDTO()
        {
            Id = ""
        };
        
        var command = new DeleteStoreCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}