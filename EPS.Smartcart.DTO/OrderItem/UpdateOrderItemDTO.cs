namespace EPS.Smartcart.DTO.OrderItem;

public class UpdateOrderItemDTO
{
    public string Id { get; set; }
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public int Amount { get; set; }
}