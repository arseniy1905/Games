namespace Games.DataModel
{
    public class DeliveryDoorAccessMaster
    {
        public int ID { get; set; }
        public string DeliveryDoorAccess { get; set; }
        public string DeliveryDoorAccessFR { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
