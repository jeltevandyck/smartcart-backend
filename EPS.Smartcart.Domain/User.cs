namespace EPS.Smartcart.Domain;

public class User : Entity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Order> Orders { get; set; }
    public List<GroceryList> GroceryLists { get; set; }
}