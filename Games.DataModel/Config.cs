namespace Games.DataModel
{
    public class Config
    {
        public int Id { get; set; }
        public string KeyName { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
