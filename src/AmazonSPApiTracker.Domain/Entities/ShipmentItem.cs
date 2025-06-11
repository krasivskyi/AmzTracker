using System.ComponentModel.DataAnnotations;

namespace AmazonSPApiTracker.Domain.Entities;

public class ShipmentItem
{
    public string ShipmentId { get; set; } = string.Empty;
    public Shipment? Shipment { get; set; }

    public string SkuId { get; set; } = string.Empty;
    public Sku? Sku { get; set; }
    public int Quantity { get; set; }
    public int QuantityReceived { get; set; }
} 