using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<ServiceUsage> ServiceUsages { get; set; } = new List<ServiceUsage>();
}
