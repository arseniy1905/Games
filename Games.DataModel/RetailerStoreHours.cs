
using System;

namespace Games.DataModel
{
    public class RetailerStoreHours
    {
        public int ID { get; set; }
        public Retailer Retailer { get; set; }
        public int RetailerId { get; set; }
        public Store Store { get; set; }
        public int StoreId { get; set; }
        public DayMaster Day { get; set; }
        public int DayID { get; set; }
        public bool IsClosed { get; set; }
        public string OpenHour { get; set; }
        public string CloseHour { get; set; }
        public StatusMaster Status { get; set; }
        public int StatusId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
