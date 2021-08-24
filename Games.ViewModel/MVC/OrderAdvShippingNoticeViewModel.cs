using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrderAdvShippingDocumentInfoViewModel
    { 
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string ShipmentIDToLoad { get; set; }
        public bool IsMobile { get; set; }
        public List<ASNShipmentInfo> ShipmentIds { get; set; }
    }
    public class ASNShipmentInfo { 
        public long Id { get; set; }
        public string ShipmentId { get; set; }
    }

    public class OrderAdvShippingNoticeViewModel
    {
        public OrderAdvShippingNoticeViewModel()
        {
            Items = new List<OrderAdvShipNoticeDetailViewModel>();
        }
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string ShipmentId { get; set; }
        public string ContainerId { get; set; }    
        public string ShipmentDate { get; set; }
        public List<OrderAdvShipNoticeDetailViewModel> Items { get; set; }
    }

    public class OrderAdvShipNoticeDetailViewModel
    {
        public string ContainerID { get; set; }
        public string SKU { get; set; }
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
        public string Vendor { get; set; }
        public string Brand { get; set; }
        public string CaseGTIN { get; set; }
        public string ExpiryDate { get; set; }
        public string BatchLot { get; set; }
        public string PackGTIN { get; set; }
        public string EachGTIN { get; set; }
        public string GTINBarCode { get; set; }
        public decimal ShippedQty { get; set; }
        public string UnitOfMeassure { get; set; }
        public decimal UnitOfMeassureConversion { get; set; }
        public decimal UnitOfMeassureConversionQty { get; set; }

    }
}
