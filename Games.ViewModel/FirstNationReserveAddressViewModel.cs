using Games.Common.Enums;
using Games.Common.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class FirstNationReserveAddressViewModel : RetailerAddressAbstractViewModel
    {
        public FirstNationReserveAddressViewModel()
        {
            AddressTypeId = (int)EnumAddressType.FirstNationReserveAddress;
        }
        public int Id { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Street")]
        [MaxLength(200), Required(ErrorMessageResourceName = "EnterStreetFirstNationReserveAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string Street { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Street2")]
        public string Street2 { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "City")]
        [MaxLength(50), Required(ErrorMessageResourceName = "EnterCityFirstNationReserveAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string City { get; set; }
        public int ProvinceId { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "PostalCode")]
        [Required(ErrorMessageResourceName = "EnterPostalCodeFirstNationReserveAddress", ErrorMessageResourceType = typeof(CommonResources))]
        //[PostalCode("EnterPostalCodeFirstNationReserveAddress")]
        //[RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$", ErrorMessageResourceName = "EnterPostalCodeFirstNationReserveAddress", ErrorMessageResourceType = typeof(CommonResources))]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$", ErrorMessageResourceName = "EnterPostalCodeFirstNationReserveAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string PostalCode { get; set; }
        public List<SelectListItem> ProvinceList { get; set; }


    }
}
