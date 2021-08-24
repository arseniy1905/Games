using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class UserRolePermissionCategory
    {
        public UserRolePermissionCategory()
        {
            UserRolePermissionCategoryMappedRoles = new List<UserRolePermissionCategoryMappedRole>();
        }
        public int Id { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public int PermissionCategoryID { get; set; }
        public PermissionCategoryMaster PermissionCategory { get; set; }
        //public string PermissionCategoryName { get; set; }
        public bool ApplyAllPermissions { get; set; }
        public int TotalPermissionBitValue { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public bool AllowAllRoles { get; set; }
        public ICollection<UserRolePermissionCategoryMappedRole> UserRolePermissionCategoryMappedRoles { get; set; }
    }
}
