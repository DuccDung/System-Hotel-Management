using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FullName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string Role { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateOnly? HiredDate { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<CashTransaction> CashTransactions { get; set; } = new List<CashTransaction>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
