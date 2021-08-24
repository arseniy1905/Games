using Games.Common.Enums;

namespace Games.ViewModel.MVC
{
    public class ErrorViewModel
    {
        public string ErrorId { get; set; }
        public bool ShowErrorId => !string.IsNullOrEmpty(ErrorId);
        public int UserId { get; set; }
        public string ErrorTitle { get; set; }
        public string ErrorDescription { get; set; }
        public EnumErrorType ErrorType { get; set; }
        
    }
}
