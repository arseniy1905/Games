using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class UserRolePermissionCategoryViewModel
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public int PermissionCategoryID { get; set; }
        public string PermissionCategoryName { get; set; }
        public string PermissionName { get; set; }
        public bool IsRoleMappingRequired { get; set; }
        public bool ApplyAllPermissions { get; set; }
        public bool AllowAllRoles { get; set; }
        public int TotalPermissionBitValue { get; set; }

        public List<PermissionViewModel> permissionViewModels { get; set; }
        public List<UserRolePermissionCategoryMappedUserRolesViewModel> UserRolePermissionCategoryMappedUserRoles { get; set; }

    }
    public class UserRolePermissionCategoryMappedUserRolesViewModel
    {
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public bool Selected { get; set; }
    }


    //public class PermissionCategoryViewModel
    //{ 
    //    public int Id { get; set; }
    //    public string PermissionCategoryName { get; set; }
    //    public string PermissionCategoryNameFr { get; set; }
    //}

}
