using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RetailerUsersViewModel : BaseViewModel
    {
        public RetailerUsersViewModel()
        {
            UserList = new List<UserDetailViewModel>();
            //UserRoles = new List<UserRoleViewModel>();
        }
        public List<UserDetailViewModel> UserList { get; set; }
        
        public int UserRole { get; set; }

        //public List<UserRoleViewModel> UserRoles { get; set; }
        public int RetailerId { get; set; }
        //public bool HasCreateUserPermission { get; set; }
        //public bool HasDeleteUserPermission { get; set; }
        //public bool HasUpdateUserPermission { get; set; }
        public string RetailerName { get; set; }
        public string RetailerAddress { get; set; }
    }
}
