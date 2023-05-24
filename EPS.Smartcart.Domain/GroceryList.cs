using System.Text.Json.Serialization;

namespace EPS.Smartcart.Domain;

public class GroceryList : Entity
{
    public string Note { get; set; }
    public string UserId { get; set; }
    public string StoreId { get; set; }
    [JsonIgnore]
    public Store Store { get; set; }
    public List<GroceryItem> GroceryItems { get; set; }
}