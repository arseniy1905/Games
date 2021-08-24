using System;

namespace Games.DataModel
{
    public class ItemImage
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string ImageUrl { get; set; }
        public int SortOrder { get; set; }
        public bool UpdatedByAdmin { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool? ShowInSalesFlow { get; set; }
        //public ItemSKUDetail SkuDetail { get; set; }
    }
}
