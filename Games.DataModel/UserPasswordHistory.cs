using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class UserPasswordHistory
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public User UserInfo { get; set; }
        public string PasswordHash { get; set; }
        public DateTime PwdChangeDate { get; set; }
        public int? ChangedBy { get; set; }
    }
}
