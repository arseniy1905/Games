namespace Games.DataModel
{
    public class OrderTotalRangeMaster
    {
        public int Id { get; set; }
        public string TotalRange { get; set; }
        public string TotalRangeFr { get; set; }
        public decimal RangeStartValue { get; set; }
        public decimal RangeEndValue { get; set; }
        public int StatusId { get; set; }
    }
}
