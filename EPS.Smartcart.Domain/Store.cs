namespace EPS.Smartcart.Domain;

public class Store : Entity
{
    public string Name { get; set; }
    public string AddressId { get; set; }
    public Address Address { get; set; }
}