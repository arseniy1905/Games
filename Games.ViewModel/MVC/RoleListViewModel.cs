using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class RoleListViewModel:BaseAdminViewModel
    {
        public RoleListViewModel()
        {
            Paging = new PagingViewModel();
        }
        public IEnumerable<RolesAllViewModel> Roles { get; set; }
        public IEnumerable<SelectListItem> UserRoleList { get; set; }
        public string SearchWord { get; set; }
        public int SelectedRole { get; set; }
        public string SortField { get; set; }
        public PagingViewModel Paging { get; set; }
        public bool HasEditPermission { get; set; }
        public bool HasDeletePermission { get; set; }
        public bool HasCreatePermission { get; set; }

    }
}
