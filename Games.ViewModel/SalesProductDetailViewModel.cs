using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class SalesProductDetailViewModel : BaseViewModel
    {
        public string ItemNumber { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public int PlantTypeId { get; set; }
        public string PlantType { get; set; }
        public string PlantTypeImageURL { get; set; }
        public string PlantTypeDescription { get; set; }
        public string ShortDescription { get; set; }
        public decimal? MinTHC { get; set; }
        public decimal? MaxTHC { get; set; }
        public decimal? MinCBD { get; set; }
        public decimal? MaxCBD { get; set; }
        public decimal? MinPrice { get; set; }
        public string ProductImageURL { get; set; }

        public string MoreDescription { get; set; }

        public string LicensedProducer { get; set; }
        public int TerpeneNameId01 { get; set; }
        public int TerpeneNameId02 { get; set; }
        public int TerpeneNameId03 { get; set; }
        public int TerpeneNameId04 { get; set; }
        public int TerpeneNameId05 { get; set; }
        public bool IsTHCCalculated { get; set; }
        public bool IsCBDCalculated { get; set; }
        public bool IsCraft { get; set; }
        public string PrimaryCBDAttrDisplay { get; set; }
        public decimal PrimaryCBDAttrMin { get; set; }
        public decimal PrimaryCBDAttrMax { get; set; }
        public string PrimaryTHCAttrDisplay { get; set; }
        public decimal PrimaryTHCAttrMin { get; set; }
        public decimal PrimaryTHCAttrMax { get; set; }
        public string SecondaryCBDAttrDisplay { get; set; }
        public decimal SecondaryCBDAttrMin { get; set; }
        public decimal SecondaryCBDAttrMax { get; set; }
        public string SecondaryTHCAttrDisplay { get; set; }
        public decimal SecondaryTHCAttrMin { get; set; }
        public decimal SecondaryTHCAttrMax { get; set; }
        public List<SalesProductSKUDetailsViewModel> SkuList { get; set; }
        //public List<ProductTagsViewModel> ProductTags { get; set; }
        public List<SalesItemAttributeCategory> ItemAttributeCategories { get; set; }
        public List<SalesProductTag> SkuTags { get; set; }
        public List<SalesProductSkuImage> SkuImages { get; set; }
        public List<SalesItemAttribute> ItemAttributes { get; set; }
        public ItemPastOrderStatisticViewModel PastOrderStat { get; set; }
        public List<OrderedSkuDetail> OrderItemSkuDetails { get; set; }
    }

    public class SalesItemAttributeCategory
    {
        public int Id { get; set; }
        public string AttributeCategory { get; set; }
        public int SortOrder { get; set; }

    }

    public class SalesItemAttribute
    {
        public int AttributeID { get; set; }
        public int PDPAttributeCategoryID { get; set; }
        public string DisplayName { get; set; }
        public string ToolTipDesc { get; set; }
        public string AttributeValue { get; set; }
        public int SortOrder { get; set; }
    }

}
