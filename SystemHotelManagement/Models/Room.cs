using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public string RoomCode { get; set; } = null!;

    public int RoomTypeId { get; set; }

    public int? Floor { get; set; }

    public bool IsActive { get; set; }

    public byte RoomStatus { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual RoomType RoomType { get; set; } = null!;
}
