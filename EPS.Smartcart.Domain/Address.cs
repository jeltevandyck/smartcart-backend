namespace EPS.Smartcart.Domain;

public class Address : Entity
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string? Extra { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
}