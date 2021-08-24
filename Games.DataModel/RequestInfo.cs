using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class RequestInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public int? CustomerType { get; set; }
        public string CustomerId { get; set; }
        public string CROLNumber { get; set; }
        public string UploadedFileName { get; set; }
        public string UploadedFileURL { get; set; }
        public int RequestTypeID { get; set; }
        public RequestTypeMaster RequestType { get; set; }
        public int RequestStatusID { get; set; }
        public RequestStatusMaster RequestStatus { get; set; }
        public int RetailerID { get; set; }
        public Retailer Retailer { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int LastUpdateBy { get; set; }
        public List<RequestStatusChangeHistory> StatusChangeHistories { get; set; }
        public int? RetailerOrganizationId { get; set; }
    }
}