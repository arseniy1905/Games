using System;

namespace Games.DataModel
{
    public class UserRolePermissionCategoryMappedRole
    {
        public int Id { get; set; }
        public int UserRolePermissionCategoryId { get; set; }
        public UserRolePermissionCategory UserRolePermissionCategory { get; set; }
        public int UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

    }
}
