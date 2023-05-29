using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class StoreTests
{
    private static Guid _guid = Guid.NewGuid();
    private static Guid _addressId = Guid.NewGuid();

    private Store _store = new Store
    {
        Id = _guid.ToString(),
        Name = "Name",
        AddressId = _addressId.ToString(),
    };

    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _store.Id);
    }
    
    [TestMethod]
    public void TestName()
    {
        Assert.AreEqual("Name", _store.Name);
    }
    
    [TestMethod]
    public void TestAddressId()
    {
        Assert.AreEqual(_addressId.ToString(), _store.AddressId);
    }
}