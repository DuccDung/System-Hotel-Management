using System;

namespace SystemHotelManagement.Models
{
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime WorkDate { get; set; }   // map DATE -> DateTime (date part)
        public bool IsPresent { get; set; }
        public decimal? WorkHours { get; set; }
        public string? Note { get; set; }
        public int? MarkedBy { get; set; }
        public DateTime MarkedAt { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Employee? MarkedByNavigation { get; set; }
    }
}
