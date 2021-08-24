using System;


namespace Games.DataModel
{
    public class OrderDetailTemp
    {
        public OrderDetailTemp()
        {
            SessionStartTime = DateTime.Now;
            SalesOrderNumberD365 = string.Empty;
            OrderStatusId = 0;
            RequestedOrderTotal = 0;
            RequestedOrderHST = 0;
            RequestedOrderGST = 0;
            RequestedOrderPST = 0;
            RequestedOrderWeight = 0;
            RequestedOrderTotalPallets = 0;
            RequestedOrderShippingCharges = 0;
            CreatedDate = DateTime.Now;
        }
        public long Id { get; set; }
        public int RetailerID { get; set; }
        public int RetailerStoreID { get; set; }
        public DateTime? SessionStartTime { get; set; }
        public DateTime? SessionEndTime { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public int RetailerOrderDay { get; set; }
        public int OrderStatusId { get; set; }
        public decimal RequestedOrderTotal { get; set; }
        public decimal RequestedOrderHST { get; set; }
        public decimal RequestedOrderGST { get; set; }
        public decimal RequestedOrderPST { get; set; }
        public decimal RequestedOrderWeight { get; set; }
        public int RequestedOrderTotalPallets { get; set; }
        public decimal RequestedOrderShippingCharges { get; set; }
        public string DeliveryAddressStreet { get; set; }
        public string DeliveryAddressStreet2 { get; set; }
        public string DeliveryAddressCity { get; set; }
        public string DeliveryAddressPostalCode { get; set; }
        public string DeliveryAddressProvince { get; set; }
        public int? DeliveryAddressProvinceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

    }




}
