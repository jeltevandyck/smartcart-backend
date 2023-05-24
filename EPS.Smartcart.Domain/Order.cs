using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Domain;

public class Order : Entity
{
    public List<OrderItem> OrderItems { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ChangedStatusDate { get; set; }
    public OrderStatus Status { get; set; }
    public string? CartId { get; set; }
}