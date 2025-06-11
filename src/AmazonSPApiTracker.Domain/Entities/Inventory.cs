using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AmazonSPApiTracker.Domain.Entities;

public class Inventory
{
    [Key]
    public string SkuId { get; set; } = string.Empty;

    [ForeignKey(nameof(SkuId))]
    public Sku? Sku { get; set; }
    public int Fulfillable { get; set; }
    public int Inbound { get; set; }
    public int Reserved { get; set; }
    public int Researching { get; set; }
    public DateTime LastUpdated { get; set; }
} 