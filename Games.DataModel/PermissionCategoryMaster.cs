using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class PermissionCategoryMaster
    {
        public int Id { get; set; }
        public string PermissionCategoryName { get; set; }
        public string PermissionCategoryNameFr { get; set; }
        public int UserTypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsRoleMappingRequired { get; set; }
        public ICollection<UserRolePermissionCategory> UserRolePermissionCategories { get; set; }
        public List<PermissionMaster> Permissions { get; set; }

    }
}
