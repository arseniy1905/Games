using System;
using System.Collections.Generic;
using System.Reflection;

namespace Games.DataModel
{
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ColorId { get; set; }
        public ColorPalletMaster Color { get; set; }
        public ICollection<UserRolePermissionCategory> UserRolePermissionCategories { get; set; }
        //public List<User> Users { get; set; }
        public int UserTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public int? UpdatedBy { get; set; }
        public ICollection<UserRolePermissionCategoryMappedRole> UserRolePermissionCategoryMappedRoles { get; set; }
    }
}
