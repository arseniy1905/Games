namespace Games.ViewModel.MVC
{
    public class ShoppingCartItemViewModel
    {
        public long ItemId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public string SKU { get; set; }
        public string OcsItemNumber { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public int PkSize { get; set; }
        public decimal PkWeight { get; set; }
        public string PlantType { get; set; }
        public int PkQuantity { get; set; }
        public int TotalQTyREQHigh { get; set; }
        public int TotalQTyREQLow { get; set; }
        public decimal TotalDollarREQHigh { get; set; }
        public decimal TotalDollarREQLow { get; set; }
        public bool HasManySKUs { get; set; }
        public decimal Total { get; set; }
        public string ItemImageURL { get; set; }
        public string Supplier { get; set; }
        public string MaxOrderQty { get; set; }
        public bool HideMaxOrderQty { get; set; }
        public bool IsOutOfStock { get; set; }
        public int OrderType { get; set; }
        public int? LeadTime { get; set; }
    }
}
