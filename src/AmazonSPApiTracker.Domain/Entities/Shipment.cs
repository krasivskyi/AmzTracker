using AmazonSPApiTracker.Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AmazonSPApiTracker.Domain.Entities;

public class Shipment
{
    [Key]
    public string ShipmentId { get; set; } = string.Empty;
    public ShipmentStatus Status { get; set; }
    public List<ShipmentItem> Items { get; set; } = new List<ShipmentItem>();
    public string DestinationFulfillmentCenterId { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public DateTime LastUpdatedDate { get; set; }
} 