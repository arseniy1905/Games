using Games.Common.Resources;
using Games.DataModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using UserType = Games.DataModel.UserType;

namespace Games.ViewModel.MVC
{
    public class UserDetailViewModel:BaseAdminViewModel
    {
        public UserDetailViewModel()
        {
            UserTypeList = new List<SelectListItem>();
            StoreList = new List<SelectListItem>();
            StatusList = new List<SelectListItem>();
            TwoFactorEnabled = true;
        }
        public int Id { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "FirstName")]
        [Required(ErrorMessageResourceName = "EnterFirstName", ErrorMessageResourceType = typeof(CommonResources))]
        public string FirstName { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "LastName")]
        [Required(ErrorMessageResourceName = "EnterLastName", ErrorMessageResourceType = typeof(CommonResources))]
        public string LastName { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "EmailUserName")]
        [EmailAddress(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        [StringLength(150, ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        public string Email { get; set; }
        //[Display(ResourceType = typeof(CommonResources), Name = "UserType")]
        //[Required(ErrorMessageResourceName = "SelectUserType", ErrorMessageResourceType = typeof(CommonResources))]
        public int? UserTypeId { get; set; }
        public List<SelectListItem> UserTypeList { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "AccossiatedStore")]
        [Required(ErrorMessageResourceName = "SelectStore", ErrorMessageResourceType = typeof(CommonResources))]
        public int StoreId { get; set; }
        public List<SelectListItem> StoreList { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "UserStatus")]
        [Required(ErrorMessageResourceName = "SelectStatus", ErrorMessageResourceType = typeof(CommonResources))]
        public int StatusId { get; set; }
        public List<SelectListItem> StatusList { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public string Title { get => Id > 0 ? CommonResources.Edit : CommonResources.CreateUser; }
        [Display(ResourceType = typeof(CommonResources), Name = "StoreId")]
        [Required(ErrorMessageResourceName = "EnterStoreId", ErrorMessageResourceType = typeof(CommonResources))]
        public string StoreNumber { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "EmployeeId")]
        [Required(ErrorMessageResourceName = "EnterEmployeeId", ErrorMessageResourceType = typeof(CommonResources))]
        public string EmployeeId { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public string PadlockImgPath { get; set; }
        public bool Locked { get; set; }
        public bool LockoutEnabled { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }
        public UserType UserType { get; set; }
        public Retailer Retailer { get; set; }
        public string RetailerAddress { get; set; }
        public string StatusMessage { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessageResourceName = "InvalidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessageResourceName = "InvalidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set => _PhoneNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _PhoneNumber;
        public string StoreAddress { get; set; }
        public string UploadedImagePath { get; set; }
        public bool HasUpdateUserPermission { get; set; }
        public bool HasCreateUserPermission { get; set; }
        public bool HasDeleteUserPermission { get; set; }
        public object OrganizationName { get; set; }
    }
}
