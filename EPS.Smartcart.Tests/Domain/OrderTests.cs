using EPS.Smartcart.Domain;
using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class OrderTests
{
    private static Guid _guid = Guid.NewGuid();
    private static Guid _cartId = Guid.NewGuid();
    
    private static DateTime _createdDate = DateTime.Now;
    private static DateTime _changedStatusDate = DateTime.Now;

    private Order _order = new Order
    {
        Id = _guid.ToString(),
        CartId = _cartId.ToString(),
        CreatedDate = _createdDate,
        ChangedStatusDate = _changedStatusDate,
        Status = OrderStatus.UNPAID,
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _order.Id);
    }
    
    [TestMethod]
    public void TestCartId()
    {
        Assert.AreEqual(_cartId.ToString(), _order.CartId);
    }
    
    [TestMethod]
    public void TestCreatedDate()
    {
        Assert.AreEqual(_createdDate, _order.CreatedDate);
    }
    
    [TestMethod]
    public void TestChangedStatusDate()
    {
        Assert.AreEqual(_changedStatusDate, _order.ChangedStatusDate);
    }
    
    [TestMethod]
    public void TestStatus()
    {
        Assert.AreEqual(OrderStatus.UNPAID, _order.Status);
    }
}