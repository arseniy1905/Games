using Games.Common.Resources;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using UserType = Games.Common.State.UserType;

namespace Games.ViewModel.MVC
{
    public class RetailerUserInfoViewModel:BaseViewModel
    {
        public RetailerUserInfoViewModel()
        {
            NotificationIds = new List<int>();
            Notifications = new List<NotificationViewModel>();
            Permissions = new List<PermissionViewModel>();
            PermissionCategories = new List<RetailerUserPermissionCategoryViewModel>();
            PermissionCategoriesJson = string.Empty;
            Retailers = new List<RetailerViewModel>();
        }
        public int? ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(256)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(256)]
        public string Email { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
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
        public int? UserTypeId { get; set; }
        public int? UserRoleId { get; set; }
        public string StatusMessage { get; set; }
        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public string UserName { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IFormFile Image { get; set; }
        public List<UserType> UserTypes { get; set; }
        public DateTime? LastLoggedIn { get; set; }
        public int? LoginCount { get; set; }
        public string UploadedImagePath { get; set; }
        public string OriginalImagePath { get; set; }
        //public bool HasDeleteUserPermission { get; set; }
        //public bool HasUpdateUserPermission { get; set; }
        //public bool HasCreateUserPermission { get; set; }
        //public List<UserRoleViewModel> UserRoles { get; set; }
        
        public List<NotificationViewModel> Notifications { get; set; }
        public IEnumerable<int> NotificationIds { get; set; }
        public List<RetailerUserPermissionCategoryViewModel> PermissionCategories { get; set; }
        public List<PermissionViewModel> Permissions { get; set; }
        public List<RetailerViewModel> Retailers { get; set; }
        public string PermissionCategoriesJson { get; set; }
    }
}
