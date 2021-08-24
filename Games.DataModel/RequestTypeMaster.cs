namespace Games.DataModel
{
    public class RequestTypeMaster
    {
        public int Id { get; set; }
        public string RequestType { get; set; }
        public string RequestTypeFr { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
