using Games.Common.Enums;
using Games.Common.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class CorporationAddressViewModel : RetailerAddressAbstractViewModel
    {
        public CorporationAddressViewModel()
        {
            AddressTypeId = (int)EnumAddressType.CorporationAddress;
        }
        public int Id { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Street")]
        [MaxLength(200), Required(ErrorMessageResourceName = "EnterStreetCorporationAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string Street { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Street2")]
        public string Street2 { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "City")]
        [MaxLength(50), Required(ErrorMessageResourceName = "EnterCityCorporationAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string City { get; set; }
        public int ProvinceId { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "PostalCode")]
        [Required(ErrorMessageResourceName = "EnterPostalCodeCorporationAddress", ErrorMessageResourceType = typeof(CommonResources))]
        //[PostalCode("EnterPostalCodeCorporationAddress")]
        //[RegularExpression(@"^[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d$", ErrorMessageResourceName = "EnterPostalCodeCorporationAddress", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(6)]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$", ErrorMessageResourceName = "EnterPostalCodeCorporationAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string PostalCode { get; set; }
        public List<SelectListItem> ProvinceList { get; set; }


    }
}
