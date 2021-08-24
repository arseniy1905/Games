using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class PermissionCategoryViewModel
    {
        public int Id { get; set; }
        public string PermissionCategoryName { get; set; }
        public int StatusId { get; set; }
        public int PermissionCategoryID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PermissionName { get; set; }
        public bool IsRoleMappingRequired { get; set; }
        public bool ApplyAllPermissions { get; set; }
        public int TotalPermissionBitValue { get; set; }

        public List<PermissionViewModel> PermissionsViewModel { get; set; }
    }
}
