namespace AmazonSPApiTracker.Domain.Entities;

public class ShipmentItem
{
    public string SkuId { get; set; } = string.Empty;
    public Sku? Sku { get; set; }
    public int Quantity { get; set; }
    public int QuantityReceived { get; set; }
} 