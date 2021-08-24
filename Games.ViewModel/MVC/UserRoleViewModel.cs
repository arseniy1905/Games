using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class UserRoleViewModel : BaseAdminViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name Required."), MaxLength(50),]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAdded { get; set; }
        [Range(1, 10000, ErrorMessage = "Colour Required.")]
        public int ColorId { get; set; }
        public List<Games.Common.Models.ColorPalletMaster> Colors;
        public List<UserRolePermissionCategoryViewModel> PermissionCategories { get; set; }
        public List<PermissionViewModel> Permissions { get; set; }
        public UserRoleUserListViewModel UserRoleUsers { get; set; }
        public List<int> SelectedUsers { get; set; }
        public int UserTypeId { get; set; }
    }
}
