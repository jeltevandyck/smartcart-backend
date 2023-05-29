using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class ProductTests
{
    private static Guid _guid = Guid.NewGuid();
    private static Guid _storeId = Guid.NewGuid();
    
    private static DateTime _expirationDate = DateTime.Now;
    private static DateTime _productionDate = DateTime.Now;

    private Product _product = new Product
    {
        Id = _guid.ToString(),
        Name = "Name",
        Description = "Description",
        Price = 10,
        Discount = 5,
        DiscountPercentage = 10,
        Amount = 10,
        ExperitionDate = _expirationDate,
        ProductionDate = _productionDate,
        StoreId = _storeId.ToString()
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _product.Id);
    }
    
    [TestMethod]
    public void TestName()
    {
        Assert.AreEqual("Name", _product.Name);
    }
    
    [TestMethod]
    public void TestDescription()
    {
        Assert.AreEqual("Description", _product.Description);
    }
    
    [TestMethod]
    public void TestPrice()
    {
        Assert.AreEqual(10, _product.Price);
    }
    
    [TestMethod]
    public void TestDiscount()
    {
        Assert.AreEqual(5, _product.Discount);
    }
    
    [TestMethod]
    public void TestDiscountPercentage()
    {
        Assert.AreEqual(10, _product.DiscountPercentage);
    }
    
    [TestMethod]
    public void TestAmount()
    {
        Assert.AreEqual(10, _product.Amount);
    }
    
    [TestMethod]
    public void TestExpirationDate()
    {
        Assert.AreEqual(_expirationDate, _product.ExperitionDate);
    }
    
    [TestMethod]
    public void TestProductionDate()
    {
        Assert.AreEqual(_productionDate, _product.ProductionDate);
    }
    
    [TestMethod]
    public void TestStoreId()
    {
        Assert.AreEqual(_storeId.ToString(), _product.StoreId);
    }
    
    
}