namespace EPS.Smartcart.DTO.GroceryItem;

public class UpdateGroceryItemDTO
{
    public string Id { get; set; }
    public int? Amount { get; set; }
    public bool? IsCollected { get; set; }
}