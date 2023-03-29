namespace EPS.Smartcart.DTO.Product;

public class CreateProductDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }
    public double DiscountPercentage { get; set; }
    public int Amount { get; set; }
    public DateTime ExpirationDate { get; set; }
    public DateTime? ProductionDate { get; set; }
    public string StoreId { get; set; }
}