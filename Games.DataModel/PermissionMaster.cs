using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class PermissionMaster
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public string PermissionNameFr { get; set; }
        public int PermissionBitValue { get; set; }
        public int PermissionCategoryId { get; set; }
        public PermissionCategoryMaster PermissionCategory { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<MenuItemPermission> MenuItemPermissions { get; set; }
    }
}
