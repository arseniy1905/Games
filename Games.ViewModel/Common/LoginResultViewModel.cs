using Games.Common.Result;
using Games.Common.State;

namespace Games.ViewModel.Common
{
    public class LoginResultViewModel
    {
        public LoginResultViewModel()
        {
            User = new User();
            Retailer = new Retailer();
        }
        public User User { get; set; }
        public Retailer Retailer { get; set; }
        public LogInResult Result { get; set; }
        public int NoOfRetailers { get; set; }
    }
}
