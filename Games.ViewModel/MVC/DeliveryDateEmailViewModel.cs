using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class DeliveryDateEmailViewModel
    {
        public DeliveryDateEmailViewModel()
        {
            ToAddress = "";
            CcAddress = "";
            BccAddress = "";
        }
        public string ToAddress { get; set; }
        public string CcAddress { get; set; }
        public string BccAddress { get; set; }
        public string Body { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Subject { get; set; }
        public bool SuccessSendingEmail { get; set; }
        public string StoreNumber { get; set; }
        public DateTime OldDeliveryDay { get; set; }
        public DateTime OldTimeFrom { get; set; }
        public DateTime OldTimeTo { get; set; }
        public DateTime NewDeliveryDay { get; set; }
        public DateTime NewTimeFrom { get; set; }
        public DateTime NewTimeTo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
    }
}
