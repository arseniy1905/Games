namespace Games.ViewModel.MVC
{
    public class OrderSummaryItemViewModel
    {
        public long OrderItemId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string Sku { get; set; }
        public string OcsItemNumber { get; set; }
        public string SubCategory { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public int PackSize { get; set; }
        public string PackWeight { get; set; }
        public string PlantType { get; set; }
        public string Supplier { get; set; }
        public string MaxOrderQty { get; set; }
        public string TotalQtyRequired { get; set; }
        public string TotalDollarRequired { get; set; }
    }
}
