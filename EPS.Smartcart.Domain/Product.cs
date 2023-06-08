using System.Text.Json.Serialization;

namespace EPS.Smartcart.Domain;

public class Product : Entity
{
    public string Barcode { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }
    public double DiscountPercentage { get; set; }
    public int Amount { get; set; }
    public DateTime ExperitionDate { get; set; }
    public DateTime? ProductionDate { get; set; }
    public string StoreId { get; set; }
    [JsonIgnore]
    public Store Store { get; set; }
}