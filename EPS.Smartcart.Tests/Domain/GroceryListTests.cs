using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class GroceryListTests
{
    private static Guid _guid = Guid.NewGuid();
    private static Guid _userId = Guid.NewGuid();
    private static Guid _storeId = Guid.NewGuid();
    
    private GroceryList _groceryList = new GroceryList
    {
        Id = _guid.ToString(),
        Note = "GroceryList",
        UserId = _userId.ToString(),
        StoreId = _storeId.ToString(),
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _groceryList.Id);
    }
    
    [TestMethod]
    public void TestNote()
    {
        Assert.AreEqual("GroceryList", _groceryList.Note);
    }
    
    [TestMethod]
    public void TestUserId()
    {
        Assert.AreEqual(_userId.ToString(), _groceryList.UserId);
    }
    
    [TestMethod]
    public void TestStoreId()
    {
        Assert.AreEqual(_storeId.ToString(), _groceryList.StoreId);
    }
}