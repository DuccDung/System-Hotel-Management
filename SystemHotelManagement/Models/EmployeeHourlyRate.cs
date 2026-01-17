using System;

namespace SystemHotelManagement.Models
{
    public partial class EmployeeHourlyRate
    {
        public int RateId { get; set; }
        public string Role { get; set; } = null!;
        public decimal HourlyRate { get; set; }
        public bool IsActive { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
