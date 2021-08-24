using Games.Common.Enums;
using Games.Common.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class StoreAddressViewModel : RetailerAddressAbstractViewModel
    {
        public StoreAddressViewModel()
        {
            AddressTypeId = (int)EnumAddressType.StoreAddress;
        }
        public int Id { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Street")]
        [MaxLength(200), Required(ErrorMessageResourceName = "EnterStreetStoreAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string Street { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Street2")]
        public string Street2 { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "City")]
        [MaxLength(50), Required(ErrorMessageResourceName = "EnterCityStoreAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string City { get; set; }
        public int ProvinceId { get; set; }
        public List<SelectListItem> ProvinceList { get; set; }

        [Display(ResourceType = typeof(CommonResources), Name = "PostalCode")]
        [Required(ErrorMessageResourceName = "EnterPostalCodeStoreAddress", ErrorMessageResourceType = typeof(CommonResources))]
        //[PostalCode("EnterPostalCodeStoreAddress")]
        //[RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$", ErrorMessageResourceName = "EnterPostalCodeStoreAddress", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(6)]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$", ErrorMessageResourceName = "EnterPostalCodeStoreAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string PostalCode { get; set; }


    }
}
