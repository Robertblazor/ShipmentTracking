using System;

namespace BlazorApp.Shared
{
    public class InboundShipment
    {
        public int Id { get; set; }
        public string ShipmentNumber { get; set; }
        public string SupplierName { get; set; }
        public DateTime ShipmentDate { get; set; }
        public ShipmentStatus Status { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
    }

    public enum ShipmentStatus
    {
        Created,
        InTransit,
        Delivered,
        Cancelled
    }
}
