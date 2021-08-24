using System;

namespace Games.ViewModel.MVC
{
    public class OnboardingProcessViewModel
    {
        public int RequestId { get; set; }
        public int RetailerId { get; set; }
        public int RetailerStatusID { get; set; }

        public DateTime StatusChangeDate { get; set; }
        public int HistoryID { get; set; }
        public string CROLComments { get; set; }
        public string DeliveryInfoComments { get; set; }
        public string AdditionalDocumentComments { get; set; }
        public DateTime? CROLModifiedDate { get; set; }
        public DateTime? DeliveryInfoModifiedDate { get; set; }
        public DateTime? AdditionalDocumentModifiedDate { get; set; }
    }

    //public class OnboardStepComments
    //{ 
    //    public DateTime StatusChangeDate { get; set; }
    //    public string Comments { get; set; }

    //}

}
