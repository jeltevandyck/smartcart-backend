using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.DTO.Cart;

public class UpdateCartDTO
{
    public string Id { get; set; }
    public CartStatus? Status { get; set; }
    public bool ChangeCode { get; set; } = false;
    public string StoreId { get; set; }
}