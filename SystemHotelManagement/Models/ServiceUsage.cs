using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class ServiceUsage
{
    public int ServiceUsageId { get; set; }

    public int BookingId { get; set; }

    public int ServiceId { get; set; }

    public int Quantity { get; set; }

    public decimal UnitPrice { get; set; }

    public DateTime UsedAt { get; set; }

    public string? Note { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
