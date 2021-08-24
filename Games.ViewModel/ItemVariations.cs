namespace Games.ViewModel.MVC
{
    public class ItemVariations
    {
        public int? Id { get; set; }
        public string SKU { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal? Inventory { get; set; }
        public decimal? Price { get; set; }
        public decimal? PackSize { get; set; }
        public bool? ShowHidePLS { get; set; }
        public string Assortment { get; set; }
        public bool Unlimited { get; set; }
    }
}
