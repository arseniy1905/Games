using Games.Common.Resources;
using Games.Common.Validation;
using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class CROLInfoViewModel : RetailerinfoAbstractViewModel
    {
        public CROLInfoViewModel()
        {
            LegalAddress = new LegalAddressViewModel();
            //FirstNationReserveAddress = new FirstNationReserveAddressViewModel();
            StoreAddress = new StoreAddressViewModel();
            CorporationAddress = new CorporationAddressViewModel();
            OnboardProcessComments = new OnboardingProcessViewModel();
        }
        public int Id { get; set; }
        public string GenericError { get; set; }
        //public List<UserInfoStageViewModel> Stages { get; set; }
        //public string NextStepText { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "FirstName")]
        [MaxLength(50), Required(ErrorMessageResourceName = "EnterFirstName", ErrorMessageResourceType = typeof(CommonResources))]
        public string FirstName { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "LastName")]
        [MaxLength(50), Required(ErrorMessageResourceName = "EnterLastName", ErrorMessageResourceType = typeof(CommonResources))]
        public string LastName { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Email")]
        //[EmailAddress(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        //^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){1,})+)$", ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(100), Required(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        public string Email { get; set; }

        [MaxLength(10)]
        [Display(ResourceType = typeof(CommonResources), Name = "PhoneNumber")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessageResourceName = "InvalidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        //[RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$", ErrorMessageResourceName = "EnterValidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))] 
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set => _PhoneNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _PhoneNumber;

        [MaxLength(50), Display(ResourceType = typeof(CommonResources), Name = "SecondaryContactFirstName")]
        public string SecondaryContactFirstName { get; set; }

        [MaxLength(10), Display(ResourceType = typeof(CommonResources), Name = "SecondaryContactPhone")]
        [OptionalMinLength(10, ErrorMessage = null, ErrorMessageResourceName = "EnterValidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        public string SecondaryContactPhone
        {
            get
            {
                return _SecondaryContactPhone;
            }
            set => _SecondaryContactPhone = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _SecondaryContactPhone;

        [MaxLength(50), Display(ResourceType = typeof(CommonResources), Name = "SecondaryContactLastName")]
        public string SecondaryContactLastName { get; set; }
        [MaxLength(100), Display(ResourceType = typeof(CommonResources), Name = "SecondaryContactEmail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){1,})+)$", ErrorMessageResourceName = "EnterValidSecondaryEmailAddress", ErrorMessageResourceType = typeof(CommonResources))]
        public string SecondaryContactEmail { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "CROLCertificateName")]
        [MaxLength(100), Required(ErrorMessageResourceName = "CROLCertificateName", ErrorMessageResourceType = typeof(CommonResources))]
        public string CROLCertificateName { get; set; }
        [Range(1, 10, ErrorMessage = null, ErrorMessageResourceName = "EnterEntityType", ErrorMessageResourceType = typeof(CommonResources))]
        [Required(ErrorMessageResourceName = "EnterEntityType", ErrorMessageResourceType = typeof(CommonResources))]
        public int EntityTypeId { get; set; }
        public List<SelectListItem> EntityTypeList { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "RSANumber")]
        [MaxLength(7, ErrorMessageResourceName = "EnterRSANumber", ErrorMessageResourceType = typeof(CommonResources)), Required(ErrorMessageResourceName = "EnterRSANumber", ErrorMessageResourceType = typeof(CommonResources))]
        [RegularExpression(@"^([0-9]{7})$", ErrorMessageResourceName = "EnterRSANumber", ErrorMessageResourceType = typeof(CommonResources))]
        public string RSANumber { get; set; }
        public LegalAddressViewModel LegalAddress { get; set; }
        //public FirstNationReserveAddressViewModel FirstNationReserveAddress { get; set; }
        public StoreAddressViewModel StoreAddress { get; set; }
        public CorporationAddressViewModel CorporationAddress { get; set; }
        public OnboardingProcessViewModel OnboardProcessComments { get; set; }
        //public string NextStepAction { get; set; }
        //public bool Validate { get; set; }

        [Display(ResourceType = typeof(CommonResources), Name = "CorporationName")]
        [Required(ErrorMessageResourceName = "EnterCorporationName", ErrorMessageResourceType = typeof(CommonResources))]
        public string CorporateName { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "FirstNationBandNumber")]
        [Required(ErrorMessageResourceName = "EnterFirstNationBandNumber", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(100, ErrorMessageResourceName = "EnterFirstNationBandNumber", ErrorMessageResourceType = typeof(CommonResources))]
        public string FirstNationBandNumber { get; set; }
        public int IsFirstNation { get; set; }
        public List<SelectListItem> IsFirstNationList { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "FirstNationRegistrationNumber")]
        [Required(ErrorMessageResourceName = "EnterFirstNationRegistrationNumber", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(100, ErrorMessageResourceName = "EnterFirstNationRegistrationNumber", ErrorMessageResourceType = typeof(CommonResources))]
        public string FirstNationRegistrationNumber { get; set; }
        public int StoreDetailId { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "StoreName")]
        [Required(ErrorMessageResourceName = "EnterStoreName", ErrorMessageResourceType = typeof(CommonResources))]
        public string StoreName { get; set; }
        public int RetailerStatusId { get; set; }
        public bool? IsExistingD365Customer { get; set; }
        //public string NextStepController { get; set; }    
    }
}
