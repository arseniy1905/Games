using Games.DataModel.DataAttribute;
using System;

namespace Games.DataModel
{
    public class RetailerAddress
    {
        public RetailerAddress()
        {
            StatusId = 1;
        }

        public int Id { get; set; }
        public int RetailerId { get; set; }
        public Retailer Retailer { get; set; }
        // public AddressType RetailerAddress { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public int AddressTypeId { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public Province Province { get; set; }
        public int ProvinceId { get; set; }
        public StatusMaster Status { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public int StatusId { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public DateTime CreatedDate { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public int CreatedBy { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public DateTime? ModifiedDate { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public int? ModifiedBy { get; set; }
        public string PostalCode { get; set; }

        [NoMappingFrom("RetailerAddressViewModel")]
        public AddressTypeMaster AddressType { get; set; }

    }
}
