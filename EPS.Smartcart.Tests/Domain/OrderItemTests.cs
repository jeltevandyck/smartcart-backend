using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class OrderItemTests
{
    private static Guid _guid = Guid.NewGuid();
    private static Guid _orderId = Guid.NewGuid();
    private static Guid _productId = Guid.NewGuid();
    
    private OrderItem _orderItem = new OrderItem
    {
        Id = _guid.ToString(),
        Amount = 1,
        OrderId = _orderId.ToString(),
        ProductId = _productId.ToString()
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _orderItem.Id);
    }
    
    [TestMethod]
    public void TestAmount()
    {
        Assert.AreEqual(1, _orderItem.Amount);
    }
    
    [TestMethod]
    public void TestOrderId()
    {
        Assert.AreEqual(_orderId.ToString(), _orderItem.OrderId);
    }
    
    [TestMethod]
    public void TestProductId()
    {
        Assert.AreEqual(_productId.ToString(), _orderItem.ProductId);
    }
}