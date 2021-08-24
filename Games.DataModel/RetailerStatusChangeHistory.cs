using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RetailerStatusChangeHistory
    {
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public Retailer Retailer { get; set; }
        public int RetailerStatusID { get; set; }
        public int RetailerStatusToID { get; set; }
        public DateTime StatusChangeDate { get; set; }
        public string Comments { get; set; }
        public int UserID { get; set; }
    }
}
