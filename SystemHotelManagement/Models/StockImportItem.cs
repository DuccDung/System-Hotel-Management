using System;

namespace SystemHotelManagement.Models
{
    public partial class StockImportItem
    {
        public int ImportItemId { get; set; }
        public int ImportId { get; set; }
        public string ItemName { get; set; } = null!;
        public string? Unit { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal LineTotal { get; private set; }

        public virtual StockImport Import { get; set; } = null!;
    }
}
