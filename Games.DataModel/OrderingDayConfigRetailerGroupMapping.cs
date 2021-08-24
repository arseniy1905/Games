using System;

namespace Games.DataModel
{
    public class OrderingDayConfigRetailerGroupMapping
    {
        public int Id { get; set; }
        public int OrderingDayConfigId { get; set; }
        public OrderingDayConfig OrderingDayConfig { get; set; }
        public int RetailerGroupId { get; set; }
        public RetailerGroup RetailerGroup { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
