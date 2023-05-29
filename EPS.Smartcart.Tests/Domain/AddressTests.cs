using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class AddressTests
{
    private static Guid _guid = Guid.NewGuid();
    
    private Address _address = new Address
    {
        Id = _guid.ToString(),
        Street = "Stationstraat",
        Number = "1",
        Extra = "Extra",
        PostalCode = "2920",
        City = "Kalmthout",
        Country = "België",
        State = "Antwerpen"
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _address.Id);
    }
    
    [TestMethod]
    public void TestStreet()
    {
        Assert.AreEqual("Stationstraat", _address.Street);
    }
    
    [TestMethod]
    public void TestNumber()
    {
        Assert.AreEqual("1", _address.Number);
    }
    
    [TestMethod]
    public void TestExtra()
    {
        Assert.AreEqual("Extra", _address.Extra);
    }
    
    [TestMethod]
    public void TestPostalCode()
    {
        Assert.AreEqual("2920", _address.PostalCode);
    }
    
    [TestMethod]
    public void TestCity()
    {
        Assert.AreEqual("Kalmthout", _address.City);
    }
    
    [TestMethod]
    public void TestCountry()
    {
        Assert.AreEqual("België", _address.Country);
    }
    
    [TestMethod]
    public void TestState()
    {
        Assert.AreEqual("Antwerpen", _address.State);
    }
}