namespace Games.DataModel
{
    public class ReceivingLocationMaster
    {
        public int ID { get; set; }
        public string ReceivingLocation { get; set; }
        public string ReceivingLocationFR { get; set; }
        public StatusMaster Status { get; set; }
        public int StatusID { get; set; }
    }
}
