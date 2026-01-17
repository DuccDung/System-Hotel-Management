using System;
using System.Collections.Generic;

namespace SystemHotelManagement.Models
{
    public partial class StockImport
    {
        public int ImportId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ImportDate { get; set; }
        public string SupplierName { get; set; } = null!;
        public string? SupplierPhone { get; set; }
        public string? SupplierEmail { get; set; }
        public string? SupplierAddress { get; set; }
        public string? Note { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual ICollection<StockImportItem> StockImportItems { get; set; } = new List<StockImportItem>();
    }
}
