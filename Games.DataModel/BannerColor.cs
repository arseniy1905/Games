namespace Games.DataModel
{
    public class BannerColour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string HexColorCode { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
