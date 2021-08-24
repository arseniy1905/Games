using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RetailerLastOrderedItem
    {
        public long Id { get; set; }
        public int RetailerId { get; set; }
        public string ItemNumber { get; set; }
        public DateTime LastOrderedDate { get; set; }
        public int Quantity { get; set; }
    }

    public class RetailerOnStockNotification
    {
        public long Id { get; set; }
        public int RetailerId { get; set; }
        public string ItemNumber { get; set; }
        public string SKU { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int StatusId { get; set; }
    }
}
