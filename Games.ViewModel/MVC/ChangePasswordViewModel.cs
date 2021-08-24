using Games.Common.Resources;
using Games.ViewModel.Validation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(CommonResources), Name = "OldPassword")]
        [Remote("ValidatePassword", "AccountSetting", ErrorMessageResourceName = "WrongOldPassword", ErrorMessageResourceType = typeof(CommonResources))]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(CommonResources), Name = "NewPassword")]
        [PasswordRequirements]
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(CommonResources), Name = "ConfirmPassword")]
        [Compare("NewPassword", ErrorMessageResourceName = "EnterSamePasswords", ErrorMessageResourceType = typeof(CommonResources))]
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string ConfirmPassword { get; set; }
    }
}
