using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? IdNumber { get; set; }

    public string? Address { get; set; }

    public bool IsMember { get; set; }

    public string? MemberLevel { get; set; }

    public int Points { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
