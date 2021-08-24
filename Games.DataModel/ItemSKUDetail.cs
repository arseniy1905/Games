using System;

namespace Games.DataModel
{
    public class ItemSKUDetail
    {
        public int Id { get; set; }
        public string ItemNumber { get; set; }
        //public Item Item { get; set; }

        public string ItemBarcode { get; set; }
        public string Archive { get; set; }
        public string AssortmentsByVariant { get; set; }
        public decimal? DriedCannEquiv { get; set; }
        public string InventColorId { get; set; }
        public string InventConfigId { get; set; }
        public string InventSizeId { get; set; }
        public string InventStyleId { get; set; }
        public int? OnHandQuantity { get; set; }
        public int? MaxQty { get; set; }
        public decimal? PackSize { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitPricePrevious { get; set; }
        public decimal? ItemPrice { get; set; }
        public decimal? ItemPricePrevious { get; set; }
        public decimal? PricePerGram { get; set; }
        public decimal? RetailPackConsumerItemSize { get; set; }
        public string RetailPackConsumerItemUnitId { get; set; }
        public decimal? RetailPackNetContent { get; set; }
        public string RetailPackNetContentUnitId { get; set; }
        public decimal? RetailPackNumberOfItems { get; set; }
        public string SKU { get; set; }
        public string TreatAsLoose { get; set; }
        public string UnitDescription { get; set; }
        public string UnitId { get; set; }
        public int StatusID { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? PriceDrop { get; set; }
        public decimal? PriceDropPercent { get; set; }
        public DateTime? PriceDropExpiryDate { get; set; }
        public decimal? PricePerGramPrevious { get; set; }
        public bool? HideInSalesFlow { get; set; }
        public bool? NewArrival { get; set; }
        public bool? BackInStock { get; set; }
        public bool? BackInStockSoon { get; set; }
        public bool? ComingSoon { get; set; }
        public int? colorId { get; set; }
        public ItemColorMaster Color { get; set; }
        public bool? HideMaxOrderQty { get; set; }
        public string FulfilmentType { get; set; }
        public int? LeadTime { get; set; }
        public bool? Unlimited { get; set; }

        //public List<ItemImage> Images { get; set; }
    }
}
