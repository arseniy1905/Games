using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RetailerUserPermissionCategoryViewModel
    {
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public int UserId { get; set; }
        public int PermissionCategoryID { get; set; }
        public string PermissionCategoryName { get; set; }
        public string PermissionName { get; set; }
        public bool ApplyAllPermissions { get; set; }
        public int TotalPermissionBitValue { get; set; }

        public List<PermissionViewModel> permissionViewModels { get; set; }
        //public List<RetailerUserPermissionCategoryMappedUser> MappedCategories { get; set; }
    }
}
