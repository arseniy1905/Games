namespace Games.DataModel
{
    public class Resource
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public string Value { get; set; }
        public string ValueFr { get; set; }
        public string Key { get; set; }
    }
}
