using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int BookingId { get; set; }

    public decimal Amount { get; set; }

    public string Method { get; set; } = null!;

    public DateTime PaidAt { get; set; }

    public int? ReceivedBy { get; set; }

    public string? Note { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual Employee? ReceivedByNavigation { get; set; }
}
