using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class UserLoginHistory
    {
        public int Id { get; set; }
        public string IPAddress { get; set; }
        public DateTime LogInDate { get; set; }
        public bool LogInSuccess { get; set; }
        public string Passcode { get; set; }
        public string SessionId { get; set; }
        public string UserBrowser { get; set; }
        public string UserName { get; set; }
        public bool UserNameFound { get; set; }
    }
}
