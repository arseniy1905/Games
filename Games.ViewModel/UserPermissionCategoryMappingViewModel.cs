using Games.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class UserPermissionCategoryMappingViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionCategoryId { get; set; }
        public int TotalPermissionBitValue { get; set; }
        public int StatusId { get; set; }

        public List<UserRolePermissionCategoryViewModel> PermissionCategories { get; set; }
    }
}
