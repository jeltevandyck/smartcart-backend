using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.Application.Validation.Cart;
using EPS.Smartcart.DTO.Cart;

namespace EPS.Smartcart.Tests.Validation.Cart;

[TestClass]
public class CreateCartValidationTest : AbstractValidationTest<CreateCartValidation, CreateCartCommand>
{
    [TestMethod]
    public async Task CreateCartValidation()
    {
        var dto = new CreateCartDTO
        {
            StoreId = "c0a80101-0000-0000-0000-000000000001"
        };

        var command = new CreateCartCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsTrue(result.IsValid);
    }
    
    [TestMethod]
    public async Task CreateCartValidationFalse()
    {
        var dto = new CreateCartDTO
        {
            StoreId = ""
        };

        var command = new CreateCartCommand(dto);
        var result = await Validation.ValidateAsync(command);
        
        Assert.IsFalse(result.IsValid);
    }
}