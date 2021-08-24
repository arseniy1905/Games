namespace Games.DataModel
{
    public class BannerStatusMaster
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string StatusNameFr { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public string HexColorCode { get; set; }
    }
}
