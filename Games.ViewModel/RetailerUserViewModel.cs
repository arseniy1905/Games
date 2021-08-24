using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RetailerUserViewModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
        public string AvatarImageSrc { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string StatusMessage { get; set; }
    }
}
