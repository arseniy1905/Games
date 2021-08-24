namespace Games.DataModel
{
    public class ColorPalletMaster
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorNameFr { get; set; }
        public string ColorCode { get; set; }
        public StatusMaster Status { get; set; }
        public int StatusID { get; set; }
    }
}
