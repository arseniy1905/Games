namespace Games.DataModel
{
    public class BannerWebPage
    {
        public int Id { get; set; }
        public int BannerId { get; set; }
        public Banner Banner { get; set; }
        public int WebPageId { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
