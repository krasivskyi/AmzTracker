namespace AmazonSPApiTracker.Domain.Entities;

public class SalesHistory
{
    public string SkuId { get; set; } = string.Empty;
    public Sku? Sku { get; set; }
    public DateTime Date { get; set; }
    public int UnitsSold { get; set; }
} 