namespace Games.DataModel
{
    public class AddressTypeMaster
    {
        public int Id { get; set; }
        public string AddressType { get; set; }
        public string AddressTypeFR { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}