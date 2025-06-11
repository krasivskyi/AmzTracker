namespace AmazonSPApiTracker.Domain.Entities;

public class Inventory
{
    public string SkuId { get; set; } = string.Empty;
    public Sku? Sku { get; set; }
    public int Fulfillable { get; set; }
    public int Inbound { get; set; }
    public int Reserved { get; set; }
    public int Researching { get; set; }
    public DateTime LastUpdated { get; set; }
} 