using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public int EmployeeId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? PasswordSalt { get; set; }

    public bool IsLocked { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
