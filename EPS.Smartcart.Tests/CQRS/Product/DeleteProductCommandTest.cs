using EPS.Smartcart.Application.CQRS.Product;
using EPS.Smartcart.DTO.Product;

namespace EPS.Smartcart.Tests.CQRS.Product;

[TestClass]
public class DeleteProductCommandTest : AbstractCQRSHelper<DeleteProductCommandHandler>
{
    [TestMethod]
    public async Task DeleteProduct()
    {
        var dto = new DeleteProductDTO()
        {
            Id = "c0a80101-0000-0000-0000-000000000001"
        };
        
        var command = new DeleteProductCommand(dto);
        var result = await _handler.Handle(command, CancellationToken.None);
        
        Assert.IsNotNull(result);
    }
}