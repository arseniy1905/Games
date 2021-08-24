using System;
using System.Collections.Generic;

namespace Games.DataModel.SP.Params
{
    public class UpdateProductPriceInformationParams
    {
        public string ItemNumber { get; set; }
    }

    public class CalculateOrderTotalsParams
    {
        public long OrderId { get; set; }
    }

    public class CreateOrderInputParams
    {
        public int UserId { get; set; }
        public long TempOrderID { get; set; }

    }
    public class SpCreateMainOrder
    {
        public List<MainOrderInformation> Views { get; set; }
        //public long MainOrderID { get; set; }
    }
    public class MainOrderInformation
    {
        public long MainOrderID { get; set; }
        public long FlowThruMainOrderID { get; set; }
    }

    public class UpdateDeliveryScheduleInputParams
    {
        public int DocumentId { get; set; }
    }
    public class SpUpdateDeliverySchedule
    {
        public List<UpdatedDeliveryScheduleRecords> Views { get; set; }
        //public long MainOrderID { get; set; }
    }
    public class UpdatedDeliveryScheduleRecords
    {
        public string StoreNumber { get; set; }
        public int RetailerId { get; set; }
        public string Email { get; set; }
        public string UserFullName { get; set; }
        public string StoreName { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string ProvinceName { get; set; }
        public DateTime OrderDay { get; set; }
        public DateTime DeliveryDay { get; set; }
        public DateTime DeliveryTimeFrom { get; set; }
        public DateTime DeliveryTimeTo { get; set; }
        public DateTime NewDeliveryDay { get; set; }
        public DateTime NewDeliveryTimeFrom { get; set; }
        public DateTime NewDeliveryTimeTo { get; set; }

    }
}
