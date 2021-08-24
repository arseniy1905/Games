using Games.Common.Resources;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using UserType = Games.Common.State.UserType;

namespace Games.ViewModel.MVC
{
    public class UserInfoViewModel:BaseAdminViewModel
    {
        public UserInfoViewModel()
        {
            AssignedRetailers = new List<CustomSelectViewModel>();
            Retailers = new List<RetailerViewModel>();
            Permissions = new List<PermissionViewModel>();
        }
        public int? ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(256)]
        public string LastName { get; set; }
        [Required]
        //[EmailAddress(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){1,})+)$", ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(256)]
        public string Email { get; set; }
        [MaxLength(14),Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        [DataType(DataType.PhoneNumber, ErrorMessageResourceName = "InvalidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        //[RegularExpression(@"^([0-9]{10})$", ErrorMessageResourceName = "InvalidPhoneNumber", ErrorMessageResourceType = typeof(CommonResources))]
        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set => _PhoneNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _PhoneNumber;
        public int? UserTypeId { get; set; }
        public string UserType { get; set; }
        public int? UserRoleId { get; set; }
        public string StatusMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PadlockImgPath { get; set; }
        public bool LockoutEnabled { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public string UserName { get; set; }
        public string PermissionCategories { get; set; }
        public List<RetailerUserPermissionCategoryViewModel> PermissionCategory { get; set; }
        public List<PermissionViewModel> Permissions { get; set; }
        public IEnumerable<CustomSelectViewModel> Notifications { get; set; }
        //public string Notification { get; set; }
        public IEnumerable<int> NotificationIds { get; set; }
        public string RetailerName { get; set; }
        public string StoreLocation { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IFormFile Image { get; set; }
        public List<UserType> UserTypes { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public int? LoginCount { get; set; }
        public string UploadedImagePath { get; set; }
        public string OriginalImagePath { get; set; }
        public List<RetailerViewModel> Retailers { get; set; }
        public bool HasDeleteOCSUserPermission { get; set; }
        public bool HasUpdateOCSUserPermission { get; set; }
        public bool HasCreateOCSUserPermission { get; set; }
        public bool HasDeleteRetailerUserPermission { get; set; }
        public bool HasUpdateRetailerUserPermission { get; set; }
        public bool HasCreateRetailerUserPermission { get; set; }
        public bool HasModifyRetailerUserAccessPermission { get; set; }
        public int? RetailerOrganizationId { get; set; }
        //public List<UserRoleViewModel> UserRoles { get; set; }
        public List<int> SelectedUsers { get; set; }
        public List<CustomSelectViewModel> AssignedRetailers { get; set; }
        public IEnumerable<int> AssignedRetailerIds { get; set; }
        
    }

    public class PermissionCategories
    {
        public string CategoryID { get; set; }

        public List<SubCategory> SubCategory { get; set; }
    }

    public class SubCategory
    {
        public string Id { get; set; }
        public string IsChecked { get; set; }
    }
}
