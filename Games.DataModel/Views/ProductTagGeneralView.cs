namespace Games.DataModel.Views
{
    public class ProductTagGeneralView
    {
        public string NameOfTag { get; set; }
        public bool IsTagSearchable { get; set; }
        public bool IsSalesFlow { get; set; }
        public int ColorId { get; set; }

        public int? TagTypeId { get; set; }
    }
}
