using System;


namespace Games.DataModel
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public long TempOrderId { get; set; }
        public Retailer RetailerInfo { get; set; }
        public int RetailerID { get; set; }
        public int RetailerStoreID { get; set; }
        public DateTime? SessionStartTime { get; set; }
        public DateTime? SessionEndTime { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public int? RetailerOrderDay { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatusMaster OrderStatus { get; set; }
        public decimal? RequestedOrderTotal { get; set; }
        public decimal? RequestedOrderHST { get; set; }
        public decimal? RequestedOrderGST { get; set; }
        public decimal? RequestedOrderPST { get; set; }
        public decimal? RequestedOrderWeight { get; set; }
        public int? RequestedOrderTotalPallets { get; set; }
        public decimal? RequestedOrderShippingCharges { get; set; }
        public decimal? AllocatedOrderTotal { get; set; }
        public decimal? AllocatedOrderHST { get; set; }
        public decimal? AllocatedOrderGST { get; set; }
        public decimal? AllocatedOrderPST { get; set; }
        public decimal? AllocatedOrderWeight { get; set; }
        public int? AllocatedOrderTotalPallets { get; set; }
        public decimal? AllocatedOrderShippingCharges { get; set; }
        public string DeliveryAddressStreet { get; set; }
        public string DeliveryAddressStreet2 { get; set; }
        public string DeliveryAddressCity { get; set; }
        public string DeliveryAddressPostalCode { get; set; }
        public string DeliveryAddressProvince { get; set; }
        public int? DeliveryAddressProvinceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public User SubmittedUserInfo { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DeliveryTimeFrom { get; set; }
        public DateTime? DeliveryTimeTo { get; set; }
        public bool? IsEditMode { get; set; }
        public int? OrderTypeId { get; set; }
    }

}
