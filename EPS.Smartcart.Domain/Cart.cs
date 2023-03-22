using EPS.Smartcart.Domain.Types;

namespace EPS.Smartcart.Domain;

public class Cart : Entity
{
    public CartStatus Status { get; set; }
    public string Code { get; set; }
}