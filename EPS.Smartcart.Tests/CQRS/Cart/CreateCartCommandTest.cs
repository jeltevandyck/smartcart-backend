using EPS.Smartcart.Application.CQRS.Cart;
using EPS.Smartcart.DTO.Cart;

namespace EPS.Smartcart.Tests.CQRS.Cart;

[TestClass]
public class CreateCartCommandTest : AbstractCQRSHelper<CreateCartCommandHandler>
{
    
    [TestMethod]
    public void CreateCart()
    {
        var dto = new CreateCartDTO
        {
            StoreId = "c0a80101-0000-0000-0000-000000000001",
        };
        
        var command = new CreateCartCommand(dto);
        var result = _handler.Handle(command, CancellationToken.None);

        result.Wait();

        Assert.IsNotNull(result);
        
    }
    
}