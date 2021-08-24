using System;

namespace Games.DataModel
{
    public class OrderItemSKUDetailTemp
    {
        public OrderItemSKUDetailTemp()
        {
            CreatedDate = DateTime.Now;
        }
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long OrderItemId { get; set; }
        public OrderItemDetailTemp OrderItemDetailInfo { get; set; }
        public string ItemNumber { get; set; }
        public string SKU { get; set; }
        public string ItemBarCode { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        //public int  ItemColorId { get; set; }
        public int PackSize { get; set; }
        public decimal DriedCannEquiv { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal PricePerGram { get; set; }
        public int RequestedHighProbPacks { get; set; }
        public int RequestedLowProbPacks { get; set; }
        public decimal RequestedTotalHighProbPrice { get; set; }
        public decimal RequestedTotalLowProbPrice { get; set; }
        public int? OriginalRequestedHighProb { get; set; }
        public int? OriginalRequestedLowProb { get; set; }
        public int StatusId { get; set; }
        public bool? SkuOutOfStock { get; set; }
        //public decimal RequestedWeight { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        //public int AllocatedPacks { get; set; }
        //public decimal AllocatedPacksTotalPrice { get; set; }
        public int? MaxQty { get; set; }
        public int OrderTypeId { get; set; }
        public int? LeadTime { get; set; }
    }
}
