using Games.Common.Resources;
using System.ComponentModel.DataAnnotations;
using Games.ViewModel.MVC;
namespace Games.ViewModel.Common.Account
{
    public class ResetPasswordViewModel:BaseViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(CommonResources), Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(CommonResources), Name = "ConfirmPassword")]
        [Compare("Password", ErrorMessageResourceName = "EnterSamePasswords", ErrorMessageResourceType = typeof(CommonResources))]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(256)]
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
