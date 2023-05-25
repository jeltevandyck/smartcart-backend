using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.DTO.Cart;

public class UpdateCartDTO
{
    public string Id { get; set; }
    public string? UserId { get; set; }
    public string? GroceryListId { get; set; }
}