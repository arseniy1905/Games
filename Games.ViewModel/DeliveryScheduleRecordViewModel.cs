using Games.ViewModel.Validation;
using System;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class DeliveryScheduleRecordViewModel
    {
        public int Id { get; set; }
        public int DeliveryWeek { get; set; }
        public DateTime DeliveryTimeFrom { get; set; }
        public string StoreNumber { get; set; }
        public string RouteNumber { get; set; }
        public int? Stop { get; set; }
        public string StoreName { get; set; }
        public string Organization { get; set; }
        public IEnumerable<string> RetailerGroups { get; set; }
        public string Address { get; set; }

        [MustBeLaterThan("DeliveryTimeFrom")]
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

        public string DeliveryStartTime { 
            get
            {
                return DeliveryTimeFrom.ToString("hh:mm tt");
            }
        }
        public string DeliveryEndTime
        {
            get
            {
                return DeliveryTimeTo.ToString("hh:mm tt");
            }
        }
    }
}
