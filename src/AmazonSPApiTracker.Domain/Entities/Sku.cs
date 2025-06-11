namespace AmazonSPApiTracker.Domain.Entities;

public class Sku
{
    public string Id { get; set; } = string.Empty; // The Seller SKU
    public string Asin { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
} 