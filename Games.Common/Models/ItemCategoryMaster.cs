using System;
using System.Collections.Generic;

namespace Games.Common.Models
{
    public class ItemCategoryMaster
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string CategoryFr { get; set; }
        public List<ItemSubCategoryMaster> SubCategories { get; set; }
        //public DateTime UpdatedDate { get; set; }
    }

    public class ItemSubCategoryMaster
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public ItemCategoryMaster Category { get; set; }
        public string SubCategory { get; set; }
        public string SubCategoryFr { get; set; }
        public List<ItemSubSubCategoryMaster> SubSubCategories { get; set; }

    }

    public class ItemSubSubCategoryMaster
    {
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public ItemSubCategoryMaster SubCategory { get; set; }
        public string SubSubCategory { get; set; }
        public string SubSubCategoryFr { get; set; }

    }
    public class MainOrderStatusCache
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public string OrderStatusFr { get; set; }
    }
    public class MainRetailerStoreCache
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
    public class OrderStatusCache
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public string OrderStatusFr { get; set; }
    }
    public class HolidayMasterCacheModel
    {
        public int Id { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Holiday { get; set; }
        public string HolidateFr { get; set; }
    }
    public class DocumentTypeMasterCacheModel
    {
        public int Id { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTypeFr { get; set; }
    }

    public class RetailerLocationCacheModel
    {
        public int Id { get; set; }
        public string LocationAddress { get; set; }
        public string LocationAddressFr { get; set; }
    }

    public class HomePagePredefinedActionCacheModel
    {
        public int Id { get; set; }
        public int PermissionId { get; set; } 
        public string PredefinedAction { get; set; }
        public string PredifinedActionLink { get; set; }
        public int StatusId { get; set; }
    }

    public class HomePageTemplateContentBlockMasterCacheModel
    {
        public int Id { get; set; }
        public string ContentBlockTemplateName { get; set; }
        public int NoOfBlocksInRow { get; set; }
        public string TemplateHtml { get; set; }
    }
}
