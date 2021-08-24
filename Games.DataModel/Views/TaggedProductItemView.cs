namespace Games.DataModel.Views
{
    public class TaggedProductItemView
    {
        public int Id { get; set; }
        public bool IsTagged { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public int CategoryId { get; set; }
        public string PlantType { get; set; }
        public int PlantTypeId { get; set; }
        public string ImagePath { get; set; }
        public string SKU { get; set; }
    }
}
