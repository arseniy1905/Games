using Games.Common.Resources;
using Games.ViewModel.MVC;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.Common.Account
{
    public class ForgotPasswordViewModel:BaseViewModel
    {
        [EmailAddress(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [Required(ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [StringLength(150, ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        public string Email { get; set; }

        public bool EmailNotExists { get; set; }
    }
}
