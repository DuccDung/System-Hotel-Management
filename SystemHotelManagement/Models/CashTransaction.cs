using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class CashTransaction
{
    public int TransactionId { get; set; }

    public byte Type { get; set; }

    public string Category { get; set; } = null!;

    public decimal Amount { get; set; }

    public DateTime TransactionDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? Description { get; set; }

    public virtual Employee? CreatedByNavigation { get; set; }
}
