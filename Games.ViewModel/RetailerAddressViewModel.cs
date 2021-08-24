using Games.Common.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class RetailerAddressViewModel
    {
        public RetailerAddressViewModel()
        {
            Province = new ProvinceViewModel();
        }
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public int AddressTypeId { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public ProvinceViewModel Province { get; set; }

        [Range(1, 100, ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public int ProvinceId { get; set; }
        public int StatusId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string CorporationName { get; set; }
        public string FirstNationBandNumber { get; set; }
        public string PostalCode { get; set; }
        public string FirstNationRegistrationNumber { get; set; }
    }
}
