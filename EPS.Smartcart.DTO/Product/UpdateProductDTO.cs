namespace EPS.Smartcart.DTO.Product;

public class UpdateProductDTO
{
    public string Id { get; set; }
    public string? Barcode { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? Price { get; set; }
    public double? Discount { get; set; }
    public double? DiscountPercentage { get; set; }
    public double? Weight { get; set; }
    public int? Amount { get; set; }
    public DateTime? ExperitionDate { get; set; }
    public DateTime? ProductionDate { get; set; }
    public string StoreId { get; set; }
}