using Games.Common.Resources;
using Games.Common.Result;
using Games.ViewModel.MVC;
using System;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.Common
{
    [Serializable]
    public class LoginViewModel : BaseViewModel
    {
        [Display(ResourceType = typeof(CommonResources), Name = "EmailAddress")]
        [EmailAddress(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [Required(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [StringLength(150, ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        public string Email { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Password")]
        [Required(ErrorMessageResourceName = "EnterPassword", ErrorMessageResourceType = typeof(CommonResources))]
        [StringLength(150, ErrorMessageResourceName = "EnterPassword", ErrorMessageResourceType = typeof(CommonResources))]
        public string Password { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "RememberMe")]
        public bool RememberMe { get; set; }
        public string ReturnUrl { get; set; }
        public string CallbackUrl { get; set; }
        public string CallAction { get; set; }
        public string CallQsParams { get; set; }
        public LogInResult LoginStatus { get; set; }
        public DataModel.UserLoginHistory UserLoginHistory  { get; set; }
    }
}
