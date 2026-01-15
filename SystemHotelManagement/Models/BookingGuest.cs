using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class BookingGuest
{
    public int BookingGuestId { get; set; }

    public int BookingId { get; set; }

    public string GuestName { get; set; } = null!;

    public string? IdNumber { get; set; }

    public string? Phone { get; set; }

    public virtual Booking Booking { get; set; } = null!;
}
