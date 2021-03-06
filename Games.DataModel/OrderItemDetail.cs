using System;

namespace Games.DataModel
{
    public class OrderItemDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public OrderDetail OrderDetailInfo { get; set; }
        public long TempOrderItemID { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemNameFr { get; set; }
        //public int RetailerOrderDay { get; set; }
        //public int OrderStatusId { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string SubSubCategory { get; set; }
        public string PlantType { get; set; }
        public string Brand { get; set; }
        public string BrandFr { get; set; }
        public decimal RequestedTotalHighProbPrice { get; set; }
        public decimal RequestedTotalLowProbPrice { get; set; }
        public decimal AllocatedTotalPrice { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
