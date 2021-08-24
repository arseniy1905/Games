using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class UsersViewModel:BaseAdminViewModel
    {
        public UsersViewModel()
        {
            UserList = new List<UserDetailViewModel>();
            Paging = new PagingViewModel();
        }
        public List<UserDetailViewModel> UserList { get; set; }
        public PagingViewModel Paging { get; set; }
        public int UserRole { get; set; }

        public List<UserRoleViewModel> UserRoles { get; set; }

        public int RetailerLocation { get; set; }
        //public List<RetailerLocationViewModel> RetailerLocations { get; set; }

        public List<RetailerOrganizationViewModel> RetailerOrganizations { get; set; }
        public bool HasViewUserPermission { get; set; }
        public bool HasUpdateUserPermission { get; set; }
        public bool HasCreateUserPermission { get; set; }
        public bool HasDeleteUserPermission { get; set; }
        public bool HasViewRetailUserPermission { get; set; }
        public bool HasDeleteRetailUserPermission { get; set; }
        public bool HasEditRetailUserPermission { get; set; }
        public bool HasViewEditRetailUserAccessPermission { get; set; }

    }
}
