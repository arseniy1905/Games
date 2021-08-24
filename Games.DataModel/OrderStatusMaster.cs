namespace Games.DataModel
{
    public class OrderStatusMaster
    {
        public int Id { get; set; }
        public int MainOrderStatusID { get; set; }
        public MainOrderStatusMaster MainOrderStatus { get; set; }
        public string OrderStatus { get; set; }
        public string OrderStatusFr { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public int StatusId { get; set; }
    }

    public class MainOrderStatusMaster
    {
        public int Id { get; set; }
        public string MainOrderStatus { get; set; }
        public string MainOrderStatusFr { get; set; }
        public int StatusID { get; set; }
        public int DisplayOrder { get; set; }
    }
}
