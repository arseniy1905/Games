using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RetailerUserPermissionCategoryMapping
    {
        public int Id { get; set; }
        public int RetailerId { get; set; }
        public int UserId { get; set; }
        public int PermissionCategoryId { get; set; }
        public int TotalPermissionBitValue { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool ApplyAllPermissions { get; set; }

    }
}
