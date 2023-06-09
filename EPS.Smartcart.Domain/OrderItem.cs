using System.Text.Json.Serialization;

namespace EPS.Smartcart.Domain;

public class OrderItem : Entity
{
    public string OrderId { get; set; }
    [JsonIgnore]
    public Order Order { get; set; }
    public string ProductId { get; set; }
    public Product Product { get; set; }
    public int Amount { get; set; }
}