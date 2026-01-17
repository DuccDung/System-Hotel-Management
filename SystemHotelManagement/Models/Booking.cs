using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int RoomId { get; set; }

    public int CustomerId { get; set; }

    public DateTime CheckInPlan { get; set; }

    public DateTime? CheckOutPlan { get; set; }

    public DateTime? CheckInAt { get; set; }

    public DateTime? CheckOutAt { get; set; }

    public byte Status { get; set; }

    public decimal Deposit { get; set; }

    public string? Note { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<BookingGuest> BookingGuests { get; set; } = new List<BookingGuest>();

    public virtual Employee? CreatedByNavigation { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Room Room { get; set; } = null!;

    public virtual ICollection<ServiceUsage> ServiceUsages { get; set; } = new List<ServiceUsage>();
}
