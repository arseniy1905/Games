namespace Games.DataModel
{
    public class RequestStatusMaster
    {
        public int Id { get; set; }
        public string RequestStatus { get; set; }
        public string RequestStatusFr { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
