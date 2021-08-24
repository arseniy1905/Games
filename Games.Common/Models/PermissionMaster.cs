namespace Games.Common.Models
{
    public class PermissionMaster
    {
        public int Id { get; set; }
        public string PermissionName { get; set; }
        public int PermissionBitValue { get; set; }
        public int PermissionCategoryId { get; set; }
    }
}
