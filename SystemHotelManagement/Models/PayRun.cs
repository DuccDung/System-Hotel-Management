using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models
{
    public partial class PayRun
    {
        public int PayRunId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public string? Note { get; set; }

        public virtual Employee? CreatedByNavigation { get; set; }
        public virtual ICollection<PayRunDetail> PayRunDetails { get; set; } = new List<PayRunDetail>();
    }

    public partial class PayRunDetail
    {
        public int PayRunDetailId { get; set; }
        public int PayRunId { get; set; }
        public int EmployeeId { get; set; }
        public decimal TotalHours { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalPay { get; set; }

        public virtual PayRun PayRun { get; set; } = null!;
        public virtual Employee Employee { get; set; } = null!;
    }
}
