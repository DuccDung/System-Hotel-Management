using System;

namespace SystemHotelManagement.Models
{
    public partial class EmployeeHourlyRateOverride
    {
        public int OverrideId { get; set; }
        public int EmployeeId { get; set; }
        public decimal HourlyRate { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
