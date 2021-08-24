using System;

namespace Games.DataModel
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemNumber { get; set; }
        public int? CategoryId { get; set; }
        public ItemCategoryMaster Category { get; set; }
        public int? SubcategoryId { get; set; }
        public ItemSubCategoryMaster SubCategory { get; set; }
        public int? SubsubcategoryId { get; set; }
        public ItemSubSubCategoryMaster SubSubCategory { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public string ItemGroup { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public string Brand { get; set; }
        public string ItemDescription { get; set; }
        public string ShortDescription { get; set; }
        public string ItemNameFr { get; set; }
        public string BrandFr { get; set; }
        public string ItemDescriptionFr { get; set; }
        public string ShortDescriptionFr { get; set; }
        public int? TerpeneNameId01 { get; set; }
        public int? TerpeneNameId02 { get; set; }
        public int? TerpeneNameId03 { get; set; }
        public int? TerpeneNameId04 { get; set; }
        public int? TerpeneNameId05 { get; set; }
        public decimal? CBDMaxPercent { get; set; }
        public decimal? CBDMinPercent { get; set; }
        public decimal? THCMinPercent { get; set; }
        public decimal? THCMaxPercent { get; set; }
        public decimal? TerpenePercentMin01 { get; set; }
        public decimal? TerpenePercentMin02 { get; set; }
        public decimal? TerpenePercentMin03 { get; set; }
        public decimal? TerpenePercentMin04 { get; set; }
        public decimal? TerpenePercentMin05 { get; set; }
        public decimal? TerpenePercentMax01 { get; set; }
        public decimal? TerpenePercentMax02 { get; set; }
        public decimal? TerpenePercentMax03 { get; set; }
        public decimal? TerpenePercentMax04 { get; set; }
        public decimal? TerpenePercentMax05 { get; set; }
        public string UnitOfMeasureGroup { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ItemPlantTypeSpeciesMasterId { get; set; }
        public int? DefaultSortOrder { get; set; }
        public ItemPlantTypeSpeciesMaster ItemPlantTypeSpeciesMaster { get; set; }
        public string ItemImageURL { get; set; }
        public string BrandLogo { get; set; }
        public string CollectionStringAllItems { get; set; }
        public string CollectionStringInStock { get; set; }
        public string PrimaryCBDAttrDisplay { get; set; }
        public decimal? PrimaryCBDAttrMin { get; set; }
        public decimal? PrimaryCBDAttrMax { get; set; }
        public string PrimaryTHCAttrDisplay { get; set; }
        public decimal? PrimaryTHCAttrMin { get; set; }
        public decimal? PrimaryTHCAttrMax { get; set; }
        public string SecondaryCBDAttrDisplay { get; set; }
        public decimal? SecondaryCBDAttrMin { get; set; }
        public decimal? SecondaryCBDAttrMax { get; set; }
        public string SecondaryTHCAttrDisplay { get; set; }
        public decimal? SecondaryTHCAttrMin { get; set; }
        public decimal? SecondaryTHCAttrMax { get; set; }
        public bool? CBDPercentageRequired { get; set; }
        public bool? THCPercentageRequired { get; set; }
        public string PrimaryVendorName { get; set; }
        public bool? IsCraft { get; set; }
        //public List<ItemSKUDetail> SkuDetails { get; set; }
    }
}
