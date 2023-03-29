using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Domain;

public class Order : Entity
{
    public string UserId { get; set; }
    public User User { get; set; }  
    public List<OrderItem> OrderItems { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ChangedStatusDate { get; set; }
    public OrderStatus Status { get; set; }
}