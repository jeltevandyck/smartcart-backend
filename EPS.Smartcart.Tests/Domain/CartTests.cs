using EPS.Smartcart.Application.Utils;
using EPS.Smartcart.Domain;
using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class CartTests
{
    private static Guid _guid = Guid.NewGuid();
    private static Guid _storeId = Guid.NewGuid();
    private static Guid _userId = Guid.NewGuid();
    private static Guid _orderId = Guid.NewGuid();
    private static Guid _groceryListId = Guid.NewGuid();
    private static string _code = CodeUtil.Generate(8);
    
    private Cart _cart = new Cart
    {
        Id = _guid.ToString(),
        Status = CartStatus.ACTIVE,
        Code = _code,
        StoreId = _storeId.ToString(),
        UserId = _userId.ToString(),
        OrderId = _orderId.ToString(),
        GroceryListId = _groceryListId.ToString()
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _cart.Id);
    }
    
    [TestMethod]
    public void TestStatus()
    {
        Assert.AreEqual(CartStatus.ACTIVE, _cart.Status);
    }
    
    [TestMethod]
    public void TestCode()
    {
        Assert.AreEqual(_code, _cart.Code);
    }
    
    [TestMethod]
    public void TestStoreId()
    {
        Assert.AreEqual(_storeId.ToString(), _cart.StoreId);
    }
    
    [TestMethod]
    public void TestUserId()
    {
        Assert.AreEqual(_userId.ToString(), _cart.UserId);
    }
    
    [TestMethod]
    public void TestOrderId()
    {
        Assert.AreEqual(_orderId.ToString(), _cart.OrderId);
    }
    
    [TestMethod]
    public void TestGroceryListId()
    {
        Assert.AreEqual(_groceryListId.ToString(), _cart.GroceryListId);
    }
    
    [TestMethod]
    public void TestStore()
    {
        Assert.IsNull(_cart.Store);
    }
}