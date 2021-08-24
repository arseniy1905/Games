using Games.Common.Models;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class SalesProductListViewModel : BaseViewModel
    {
        public List<ItemCategoryMaster> ItemCategories { get; set; }
        public List<TerpeneMaster> Terpenes { get; set; }
        public int MaxTHC { get; set; }
        public int MinTHC { get; set; }
        public int MaxCBD { get; set; }
        public int MinCBD { get; set; }
        public int MaxPrice { get; set; }
        public int MinPrice { get; set; }
        public string ProductUpdateTimeStamp { get; set; }
        public List<string> ItemSizes { get; set; }
        public List<string> LicenseProducers { get; set; }
        public List<PLPProductTagCollection> Collections { get; set; }
        
    }

    public class PDPRelatedProductDetailViewModel
    {
        public PDPRelatedProductDetailViewModel()
        {
            Items = new List<SalesProductListDetailsViewModel>();
            Categories = new List<RelatedProducListCategory>();
        }
        public List<RelatedProducListCategory> Categories { get; set; }
        public List<SalesProductListDetailsViewModel> Items { get; set; }
    }

    public class RelatedProducListCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class SalesProductListDetailsViewModel
    {
        public SalesProductListDetailsViewModel()
        {
            SkuList = new List<SalesProductSKUDetailsViewModel>();
            SkuImages = new List<SalesProductSkuImage>();
            SearchTags = new List<string>();
            SearchTagsAllItems = new List<string>();
        }
        public string ItemNumber { get; set; }
        public decimal? MinTHC { get; set; }
        public decimal? MaxTHC { get; set; }
        public decimal? MinCBD { get; set; }
        public decimal? MaxCBD { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public decimal? MinPriceOutOfStock { get; set; }
        public decimal? MaxPriceOutOfStock { get; set; }
        public int? PlantTypeID { get; set; }
        public int RelatedProductRuleID { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int SubSubCategoryID { get; set; }
        public int DefaultSortOrder { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public string PlantType { get; set; }
        public string PlantDescription { get; set; }
        public string PlantTypeImageURL { get; set; }
        public string ProductImageURL { get; set; }
        public int TerpeneNameId01 { get; set; }
        public int TerpeneNameId02 { get; set; }
        public int TerpeneNameId03 { get; set; }
        public int TerpeneNameId04 { get; set; }
        public int TerpeneNameId05 { get; set; }
        public bool AllOutOfStock { get; set; }
        public bool IsFlowThrough { get; set; }
        public bool IsInStockFlowThrough { get; set; }
        public string TagString { get; set; }
        public string TagStringAllItems { get; set; }
        public string SKUString { get; set; }
        public string CollectionStringInStock { get; set; }
        public string CollectionStringAllItems { get; set; }
        public List<string> SearchTags { get; set; }
        public List<string> SearchTagsAllItems { get; set; }
        public List<SalesProductSKUDetailsViewModel> SkuList { get; set; }
        public List<SalesProductSkuImage> SkuImages { get; set; }
        public bool IsTHCCalculated { get; set; }
        public bool IsCBDCalculated { get; set; }
        public string PrimaryCBDAttrDisplay { get; set; }
        public decimal? PrimaryCBDAttrMin { get; set; }
        public decimal? PrimaryCBDAttrMax { get; set; }
        public string PrimaryTHCAttrDisplay { get; set; }
        public decimal? PrimaryTHCAttrMin { get; set; }
        public decimal? PrimaryTHCAttrMax { get; set; }
        public bool THCPercentageRequired { get; set; }
        public bool CBDPercentageRequired { get; set; }
        public string LicenseProducer { get; set; }
        public bool IsCraft { get; set; }
        public List<SalesProductRelatedProductViewModel> RelatedProductList { get; set; }


    }

    public class SalesProductRelatedProductViewModel
    { 
        public string ItemNumber { get; set; }
        public string RelatedItemNumber { get; set; }
    }

    public class SalesProductSKUDetailsViewModel
    {
        public SalesProductSKUDetailsViewModel()
        {
            SkuImages = new List<SalesProductSkuImage>();
            ProductTags = new List<SalesProductTag>();
            ProductTagsAlItems = new List<SalesProductTag>();
        }
        public string GTIN { get; set; }
        public string SKU { get; set; }
        public decimal? PackSize { get; set; }
        public string VarientSize { get; set; }
        public int ColorId { get; set; }
        public string ColorCode { get; set; }
        public string ColorImageName { get; set; }
        public string ColorName { get; set; }
        public string ItemPriceText { get; set; }
        public string OriginalItemPriceText { get; set; }
        public string UnitPriceText { get; set; }
        public string OriginalUnitPriceText { get; set; }
        public string PricePerGramText { get; set; }
        public decimal PricePerGram { get; set; }
        public decimal ItemPrice { get; set; }
        public string OriginalPricePerGramText { get; set; }
        public decimal PriceForSort { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsPriceDrop { get; set; }
        public bool BackInStockSoon { get; set; }
        public bool ComingSoon { get; set; }
        public string PriceDropPercentText { get; set; }
        public string PriceDropDifferenceText { get; set; }
        public int MaxQty { get; set; }
        public int OnHandQuantity { get; set; }
        public string Unit { get; set; }
        public List<SalesProductSkuImage> SkuImages { get; set; }
        public List<SalesProductTag> ProductTags { get; set; }
        public List<SalesProductTag> ProductTagsAlItems { get; set; }
        public bool NewArrival { get; set; }
        public bool BackInStock { get; set; }
        public bool HideMaxOrderQty { get; set; }
        public bool IsFlowThrough { get; set; }
        public int LeadTime { get; set; }


    }
    public class SalesProductSkuImage
    {
        public string SKU { get; set; }
        public string ImageUrl { get; set; }

    }
    public class SalesProductTag
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string NameOfTag { get; set; }
        public string ColorCode { get; set; }
        public bool IsSearchable { get; set; }
        public bool IsSalesFlow { get; set; }
        public int TagNumber { get; set; }
    }

    public class PLPProductTagCollection
    {
        public int Id { get; set; }
        public int ItemCategoryID { get; set; }
        public int CategoryOrder { get; set; }
        public string ItemCategory { get; set; }
        public string CollectionName { get; set; }
    }
}
