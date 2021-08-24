namespace Games.DataModel
{
    public class MenuItemPermission
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public PermissionMaster Permission { get; set; }
        public int MenuItemId { get; set; }
        public MenuItemMaster MenuItem { get; set; }
        public int StatusId { get; set; }
    }
}
