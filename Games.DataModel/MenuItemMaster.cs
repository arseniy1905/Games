using System.Collections.Generic;

namespace Games.DataModel
{
    public class MenuItemMaster
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TitleFr { get; set; }
        public string ToolTip { get; set; }
        public string ToolTipFr { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string ImageFile { get; set; }
        public string ImageFileSelected { get; set; }
        public int? PermissionID { get; set; }
        public int? ParentId { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public ICollection<MenuItemPermission> MenuItemPermissions { get; set; }

    }
}
