using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class UserRoleUserListViewModel
    {
        public UserRoleUserListViewModel()
        {
            Paging = new PagingViewModel();
        }
        public IEnumerable<UserDetailViewModel> UserList { get; set; }
        //public IEnumerable<SelectListItem> UserRoleList { get; set; }
        public string SearchWord { get; set; }
        public string SortField { get; set; }
        public PagingViewModel Paging { get; set; }
        public int RoleId { get; set; }
    }
}
