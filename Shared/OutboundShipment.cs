using System;

namespace BlazorApp.Shared
{
    public class OutboundShipment
    {
        public int Id { get; set; }
        public string ShipmentNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime ShipmentDate { get; set; }
        public ShipmentStatus Status { get; set; }
        public string TrackingNumber { get; set; }
        public string Carrier { get; set; }
        public string DestinationAddress { get; set; }
    }

    public enum ShipmentStatus
    {
        Created,
        InTransit,
        Delivered,
        Cancelled
    }
}