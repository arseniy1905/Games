using System;

namespace Games.DataModel
{
    public class UserPermissionCategoryMapping
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PermissionCategoryId { get; set; }
        public int TotalPermissionBitValue { get; set; }
        public StatusMaster Status { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool ApplyAllPermissions { get; set; }

    }
}
