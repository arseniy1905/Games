//using Microsoft.AspNetCore.Identity;
using System;

namespace Games.Common.State
{
    [Serializable]
    public class User //: IUserStore
    {
        public User()
        {
            UserType = new UserType();
            //    Store = new Store();
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public UserType UserType { get; set; }
        //public Store Store { get; set; }
        public bool IsAuthenticated { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string UploadedImagePath { get; set; }
        public int? UserRoleId { get; set; }
        public string UserRole { get; set; }
        public int AccessFailedCount { get; set; }
        public bool? IsBRT { get; set; }
        public int? BRTRole { get; set; }
        //public int PLPViewMode { get; set; }
        //public int PLPPriceMode { get; set; }

        //string Id => Id.ToString();

        //string UserName
        //{
        //    get
        //    {
        //        return UserName;
        //    }
        //    set
        //    {
        //        UserName = value;
        //    }
        //}
    }
}
