using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Domain;

[TestClass]
public class UserTests
{
    private static Guid _guid = Guid.NewGuid();
    
    private static DateTime _birthDate = DateTime.Now;

    private User _user = new User
    {
        Id = _guid.ToString(),
        FirstName = "FirstName",
        LastName = "LastName",
        Email = "Email",
        BirthDate = _birthDate,
    };
    
    [TestMethod]
    public void TestId()
    {
        Assert.AreEqual(_guid.ToString(), _user.Id);
    }
    
    [TestMethod]
    public void TestFirstName()
    {
        Assert.AreEqual("FirstName", _user.FirstName);
    }
    
    [TestMethod]
    public void TestLastName()
    {
        Assert.AreEqual("LastName", _user.LastName);
    }
    
    [TestMethod]
    public void TestEmail()
    {
        Assert.AreEqual("Email", _user.Email);
    }
    
    [TestMethod]
    public void TestBirthDate()
    {
        Assert.AreEqual(_birthDate, _user.BirthDate);
    }
}