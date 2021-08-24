using Games.Common.Enums;
using System;
using System.Collections.Generic;


namespace Games.ViewModel.MVC
{
    public class OrderHistoryOrderDetailViewModel
    {
        public OrderHistoryOrderDetailViewModel()
        {
            ViewType = (int)EnumOrderHistoryDetailViewType.OrderDetail;
        }
        public long OrderId { get; set; }
        public string SalesOrderId { get; set; }
        public int RetailerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? DeliveredOn { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryWindow { get; set; }
        public decimal ItemsSubTotal { get; set; }
        public decimal ShippingFees { get; set; }
        public decimal TotalBeforeTax { get; set; }
        public decimal EstimatedHST { get; set; }
        public int PalletCount { get; set; }
        public decimal NewItemSubTotal { get; set; }
        public decimal NewShippingFees { get; set; }
        public decimal NewTotalBeforeTax { get; set; }
        public decimal NewEstimatedHST { get; set; }
        public int NewPalletCount { get; set; }
        public int ViewType { get; set; }
        public bool IsMobile { get; set; }
        public bool IsOCSAdminView { get; set; }
        public int OrderTypeId { get; set; }
        public List<OrderHistoryOrderItemViewModel> OrderItems { get; set; }
    }

    public class OrderHistoryOrderItemViewModel
    {
        public long ItemId { get; set; }
        public string ItemBarCode { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string SKU { get; set; }
        public string OcsItemNumber { get; set; }
        public string SubCategory { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public int PkSize { get; set; }
        public decimal PkWeight { get; set; }
        public string PlantType { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ItemPrice { get; set; }
        public int PkQuantity { get; set; }
        public int TotalQTyREQHigh { get; set; }
        public int TotalQTyREQLow { get; set; }
        public int TotalAllocatedQty { get; set; }
        public decimal TotalDollarREQHigh { get; set; }
        public decimal TotalDollarREQLow { get; set; }
        public bool HasManySKUs { get; set; }
        public decimal Total { get; set; }
        public string ItemImageURL { get; set; }
        public string Supplier { get; set; }
        public string MaxOrderQty { get; set; }
        public bool HideMaxOrderQty { get; set; }
        public int LeadTime { get; set; }
    }
}
