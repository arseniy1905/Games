using Games.Common.Resources;
using Games.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CreateOrganizationViewModel: BaseAdminViewModel
    {
        public CreateOrganizationViewModel()
        {
            Paging = new PagingViewModel();
            SelectedRetailers = new List<int>();
            Retailers = new List<OrganizationRetailerViewModel>();
            ContactInfoList = new List<OrganizationContactInfoViewModel>();
            Users = new List<CustomSelectViewModel>();
            UserIds = new List<int>();
        }
        public PagingViewModel Paging { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessageResourceName = "EnterNameOrganization", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(225)]
        public string OrganizationName { get; set; }
        [Required(ErrorMessageResourceName = "EnterStreetOrganization", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(225)]
        public string Street { get; set; }
        public string Street2 { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string hdnselectedRetailers { get; set; }
        public bool IsDeleteable { get; set; }
        public bool HasViewOrganizationPermission { get; set; }
        public bool HasCreateOrganizationPermission { get; set; }
        public bool HasEditOrganizationPermission { get; set; }
        public bool HasDeleteOrganizationPermission { get; set; }
        public List<OrganizationRetailerViewModel> Retailers { get; set; }
        public List<int> SelectedRetailers { get; set; }
        [Required(ErrorMessageResourceName = "EnterCityOrganization", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(100)]
        public string City { get; set; }
        [Required(ErrorMessageResourceName = "EnterPostalCodeOrganization", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(6)]
        [RegularExpression(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$", ErrorMessageResourceName = "EnterPostalCodeOrganization", ErrorMessageResourceType = typeof(CommonResources))]
        public string PostalCode { get; set; }
        public int ProvinceId { get; set; }
        public List<SelectListItem> ProvinceList { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        
        public string BusinessPhone { get; set; }
        public IFormFile Image { get; set; }
        public string UploadedImagePath { get; set; }
        public string OriginalImagePath { get; set; }
        public List<OrganizationContactInfoViewModel> ContactInfoList { get; set; }
        public IEnumerable<CustomSelectViewModel> Users { get; set; }
        public IEnumerable<int> UserIds { get; set; }

    }
}
