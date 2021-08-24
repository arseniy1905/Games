using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class DeliveryScheduleDocument
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public DateTime UploadedDate { get; set; }
        public int UploadedBy { get; set; }
        public int DeliveryScheduleDocumentStatusId { get; set; }
        public List<DeliveryScheduleTemp> DeliveryScheduleTemps { get; set; }
        public DeliveryScheduleDocument(){
            DeliveryScheduleTemps = new List<DeliveryScheduleTemp>();
        }
    }
    public class DeliveryScheduleTemp
    {
        public int Id { get; set; }
        public int DocumentId{ get; set; }
        public DeliveryScheduleDocument DeliveryScheduleDocument { get; set; }

        public int DeliveryWeek { get; set; }
        public DateTime DeliveryTimeFrom { get; set; }
        public string StoreNumber { get; set; }
        public string RouteNumber { get; set; }
        public int? Stop { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryTimeTo { get; set; }
        public DateTime DeliveryDay { get; set; }
        public string City { get; set; }
        public string OrderType { get; set; }
        public DateTime? OrderDay { get; set; }
        public string Carrier { get; set; }
        public string Equipment { get; set; }
        public DateTime UploadedDate { get; set; }
        public int UploadedBy { get; set; }
        public string FileName { get; set; }
        public int StatusId { get; set; }
        public string FailedReasonResourceKey { get; set; }

    }
    public class DeliverySchedule
    {
        public int Id { get; set; }
        public int? DocumentId { get; set; }
        public int DeliveryWeek { get; set; }
        public DateTime DeliveryTimeFrom { get; set; }
        public string StoreNumber { get; set; }
        public string RouteNumber { get; set; }
        public int? Stop { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryTimeTo { get; set; }
        public DateTime DeliveryDay { get; set; }
        public string City { get; set; }
        public string OrderType { get; set; }
        public DateTime? OrderDay { get; set; }
        public string Carrier { get; set; }
        public string Equipment { get; set; }
        public DateTime UploadedDate { get; set; }
        public int UploadedBy { get; set; }
        public string FileName { get; set; }
        public int StatusId { get; set; }
        public string FailedReasonResourceKey { get; set; }

    }
}
