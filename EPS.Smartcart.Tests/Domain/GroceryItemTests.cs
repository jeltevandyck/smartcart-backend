using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class GroceryItemTests
{
    private static Guid _guid = Guid.NewGuid();
    private static Guid _groceryListId = Guid.NewGuid();
    private static Guid _productId = Guid.NewGuid();
    
    private GroceryItem _groceryItem = new GroceryItem
    {
        Id = _guid.ToString(),
        Amount = 1,
        IsCollected = false,
        GroceryListId = _groceryListId.ToString(),
        ProductId = _productId.ToString()
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _groceryItem.Id);
    }
    
    [TestMethod]
    public void TestAmount()
    {
        Assert.AreEqual(1, _groceryItem.Amount);
    }
    
    [TestMethod]
    public void TestIsCollected()
    {
        Assert.AreEqual(false, _groceryItem.IsCollected);
    }
    
    [TestMethod]
    public void TestGroceryListId()
    {
        Assert.AreEqual(_groceryListId.ToString(), _groceryItem.GroceryListId);
    }
    
    [TestMethod]
    public void TestProductId()
    {
        Assert.AreEqual(_productId.ToString(), _groceryItem.ProductId);
    }

}