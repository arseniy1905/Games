using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class OrderAdvShipNotice
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string ShipmentId { get; set; }
        public string BolNumAlpha { get; set; }
        public string Carrier { get; set; }
        public string CarrierService { get; set; }
        public string ShipDate { get; set; }
        public decimal TotalFreightCharge { get; set; }
        public decimal TotalWeight { get; set; }
        public string Warehouse { get; set; }
        public DateTime CreatedDate { get; set; }

    }

    public class OrderAdvShipNoticeDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string ShipmentId { get; set; }
        public string ShipDate { get; set; }
        public decimal LineNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string BatchNumber { get; set; }
        public string SerialId { get; set; }
        public string ContainerId { get; set; }
        public string ContainerLot { get; set; }
        public decimal QuantityAtSts1 { get; set; }
        public string Unit { get; set; }
        public decimal RequestedQty { get; set; }
        public string SKU { get; set; }
        public string ASNStatus { get; set; }
        public decimal TotalFreightCharge { get; set; }
        public decimal TotalQty { get; set; }
        public string ASNType { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CaseGTIN { get; set; }
        public string ExpiryDate { get; set; }
        public string GTINBarcode { get; set; }
        public string EachGTIN { get; set; }
        public string PackGTIN { get; set; }
    }

}
