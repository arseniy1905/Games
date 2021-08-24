namespace Games.ViewModel.MVC
{
    public class LowProbabilityNotificationSKuInfoViewModel
    {
        public string ItemNumber { get; set; }
        public string SKU { get; set; }
        public string FormattedSKU { get; set; }
        public string ItemName { get; set; }
        public string SizeColor { get; set; }
        public int QtyLowProb { get; set; }
        public int OrginalLowProbQty { get; set; }
    }

    public class OutOfStockNotificationSKuInfoViewModel
    {
        public long OrderItemId { get; set; }
        public string ItemNumber { get; set; }
        public string SKU { get; set; }
        public string FormattedSKU { get; set; }
        public string ItemName { get; set; }
        public string SizeColor { get; set; }
        public int QtyRequested { get; set; }
    }
}
