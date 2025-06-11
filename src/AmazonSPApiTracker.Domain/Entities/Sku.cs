using System.ComponentModel.DataAnnotations;

namespace AmazonSPApiTracker.Domain.Entities;

public class Sku
{
    [Key]
    public string Id { get; set; } = string.Empty; // The Seller SKU
    public string Asin { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
} 