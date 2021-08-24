using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class RetailerOrganization
    {
        public int Id { get; set; }
        public string RetailerOrganizationName { get; set; }
        public string BusinessAddressStreet { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Retailer> Retailers { get; set; }
        public string BusinessAddressStreet2 { get; set; }
        public string BusinessAddressCity { get; set; }
        public int? BusinessAddressProvinceId { get; set; }
        public string BusinessAddressPostalCode { get; set; }
        public string BusinessPhoneNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string UploadedImagePath { get; set; }
        public string OriginalImagePath { get; set; }
    }
    public class RetailerUserMapping
    {
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public Retailer Retailer { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int StatusId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
       
    }
}
