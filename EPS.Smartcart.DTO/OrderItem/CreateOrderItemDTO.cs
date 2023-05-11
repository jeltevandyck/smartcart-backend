namespace EPS.Smartcart.DTO.OrderItem;

public class CreateOrderItemDTO
{
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public int Amount { get; set; }
}