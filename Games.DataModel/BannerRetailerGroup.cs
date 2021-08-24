namespace Games.DataModel
{
    public class BannerRetailerGroup
    {
        public int Id { get; set; }
        public int BannerId { get; set; }
        public Banner Banner { get; set; }
        public int RetailerGroupId { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
