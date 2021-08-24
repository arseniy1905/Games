using System;

namespace Games.DataModel
{
    public class RequestStatusChangeHistory
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int RequestStatusID { get; set; }
        public int RequestStatusToID { get; set; }
        public DateTime StatusChangeDate { get; set; }
        public string Comments { get; set; }
        public string CROLComments { get; set; }
        public string DeliveryInfoComments { get; set; }
        public string AdditionalDocumentComments { get; set; }
        public DateTime? CROLModifiedDate { get; set; }
        public DateTime? DeliveryInfoModifiedDate { get; set; }
        public DateTime? AdditionalDocumentModifiedDate { get; set; }
        public int UserID { get; set; }
        public RequestInfo RequestInfo { get; set; }
    }
}
