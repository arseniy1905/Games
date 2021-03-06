using Games.DataModel;


namespace Games.IRepository.Unit
{
    public interface IMainUnit : IUnit
    {
        IRepository<StatusMaster> Statuses { get; }
        IRepository<User> Users { get; }
        IRepository<ProductTagCollectionCategoryMaster> ProductTagCollectionCategoryMasters { get; }
        IRepository<ProductTagCollection> ProductTagCollections { get; }
        IRepository<Config> Configurations { get; }
        IRepository<UserType> UserTypes { get; }
        IRepository<Province> Provinces { get; }
        IRepository<Store> Stores { get; }
        IRepository<UrlToken> UrlTokens { get; }
        IRepository<MenuItemMaster> MenuItemMasters { get; }
        IRepository<Location> Locations { get; }
        IRepository<RetailerGroup> RetailerGroups { get; }
        IRepository<Retailer> Retailers { get; }
        IRepository<EmailTemplate> EmailTemplates { get; }
        IRepository<EmailBlast> EmailBlasts { get; }
        IRepository<EmailBlastRetailer> EmailBlastRetailers { get; }
        IRepository<EmailBlastRetailerGroup> EmailBlastRetailerGroups { get; }
        IRepository<EmailBlastDocument> EmailBlastDocuments { get; }
        IRepository<RequestInfo> RequestInfo { get; }
        IRepository<EmailTypeMaster> EmailTypeMasters { get; }
        IRepository<EmailNotificationLog> EmailNotificationLogs { get; }
        IRepository<Resource> Resources { get; }
        IRepository<RequestStatusMaster> RequestStatusMasters { get; }
        IRepository<RequestTypeMaster> RequestTypeMasters { get; }
        IRepository<DeliveryDoorAccessMaster> DeliveryDoorAccessMasters { get; }
        IRepository<RetailerStoreDetail> RetailerStoreDetails { get; }
        IRepository<RetailerStoreHours> RetailerStoreHours { get; }
        IRepository<DayMaster> DayMasters { get; }
        IRepository<UserInfoStage> UserInfoStages { get; }
        IRepository<DocumentTypeMaster> DocumentTypeMasters { get; }
        IRepository<RetailerStoreDocument> RetailerStoreDocuments { get; }
        IRepository<RetailerStatusMaster> RetailerStatusMasters { get; }
        IRepository<RetailerAddress> RetailerAddresses { get; }
        IRepository<EntityTypeMaster> EntityTypeMasters { get; }
        IRepository<AddressTypeMaster> AddressTypeMasters { get; }
        IRepository<ReceivingLocationMaster> ReceivingLocationMaster { get; }
        IRepository<TokenTypeMaster> TokenTypeMasters { get; }
        IRepository<RetailerStageStatus> RetailerStageStatuses { get; }
        IRepository<RequestStatusChangeHistory> RequestStatusChangeHistory { get; }
        IRepository<ServiceCallLog> ServiceCallLog { get; }
        IRepository<UserRole> UserRole { get; }
        IRepository<ColorPalletMaster> ColorPalletMaster { get; }
        IRepository<PermissionCategoryMaster> PermissionCategory { get; }
        IRepository<UserRolePermissionCategory> UserRolePermissionCategory { get; }
        IRepository<PermissionMaster> PermissionMaster { get; }
        IRepository<MenuItemPermission> MenuItemPermission { get; }
        IRepository<UserRolePermissionCategoryMappedRole> UserRolePermissionCategoryMappedRoles { get; }
        IRepository<ItemCategoryMaster> ItemCategoryMasters { get; }
        IRepository<ItemSubCategoryMaster> ItemSubCategoryMasters { get; }
        IRepository<ItemSubSubCategoryMaster> ItemSubSubCategoryMasters { get; }
        IRepository<Item> Items { get; }
        IRepository<ItemSKUDetail> ItemSKUDetails { get; }
        IRepository<ItemPlantTypeSpeciesMaster> ItemPlantTypeSpeciesMasters { get; }
        IRepository<ItemSKUDetailExtension> ItemSKUDetailExtensions { get; }
        IRepository<ProductTag> ProductTags { get; }
        IRepository<ProductTagItem> ProductTagItems { get; }
        IRepository<ItemImage> ItemImages { get; }
        IRepository<ItemColorMaster> ItemColorMasters { get; }
        IRepository<ItemTerpeneMaster> ItemTerpeneMasters { get; }
        IRepository<ProductTagTypeMaster> ProductTagTypeMasters { get; }
        IRepository<ProductTagCollectionMapping> ProductTagCollectionMappings { get; }
        IRepository<ItemAttributeMaster> ItemAttributeMasters { get; }
        IRepository<ItemAttribute> ItemAttributes { get; }
        IRepository<PDPItemAttributeCategoryMaster> PDPItemAttributeCategoryMasters { get; }
        IRepository<PDPItemAttributeMaster> PDPItemAttributes { get; }
        IRepository<ItemRelationData> ItemRelationDatas { get; }

        #region STORED PROCEDURE - PLEASE DO NOT TOUCH !!!
        IRepositoryFromSql RepositoryFromSql { get; }
        #endregion
        IRepository<ProductTagDataRule> ProductTagDataRules { get; }
        IRepository<ProductTagDataRuleAttribute> ProductTagDataRuleAttributes { get; }
        IRepository<ProductTagDataRuleAttributeSign> ProductTagDataRuleAttributeSigns { get; }
        IRepository<ProductTagDataRuleAttributeType> ProductTagDataRuleAttributeTypes { get; }
        IRepository<ProductTagDataRuleLevel> ProductTagDataRuleLevels { get; }
        IRepository<ProductTagDataRuleSign> ProductTagDataRuleSigns { get; }
        IRepository<OrderDetailTemp> OrderDetailTemps { get; }
        IRepository<OrderItemDetailTemp> OrderItemDetailTemps { get; }
        IRepository<OrderItemSKUDetailTemp> OrderItemSKUDetailTemps { get; }
        IRepository<OrderDetail> OrderDetails { get; }
        IRepository<OrderItemDetail> OrderItemDetails { get; }
        IRepository<OrderItemSKUDetail> OrderItemSKUDetails { get; }

        IRepository<Banner> Banners { get; }
        IRepository<CarouselBanner> CarouselBanners { get; }
        IRepository<ReportIssue> ReportIssues { get; }
        IRepository<BannerColour> BannerColours { get; }
        IRepository<BannerRetailerGroup> BannerRetailerGroups { get; }
        IRepository<WebPage> WebPages { get; }
        IRepository<BannerWebPage> BannerWebPages { get; }
        IRepository<BannerStatusMaster> BannerStatusMasters { get; }
        IRepository<RetailerRetailerGroup> RetailerRetailerGroups { get; }
        //IRepository<ItemSubSubCategoryMaster> ItemSubSubCategoryMasters { get; }
        IRepository<DivisorTypeMaster> DivisorTypeMasters { get; }
        IRepository<SKUClassification> SKUClassifications { get; }
        IRepository<SKUClassificationProductMapping> SKUClassificationProductMappings { get; }

        IRepository<OrderingDayConfig> OrderingDayConfigs { get; }
        IRepository<OrderingDayConfigRetailerGroupMapping> OrderingDayConfigRetailerGroupMappings { get; }
        IRepository<OrderStatusMaster> OrderStatuses { get; }
        IRepository<OrderTotalRangeMaster> OrderTotalRanges { get; }
        IRepository<NotificationMaster> NotificationMasters { get; }
        IRepository<UserNotificationMapping> UserNotificationMappings { get; }
        IRepository<HolidayMaster> HolidayMasters { get; }
        IRepository<UserPermissionCategoryMapping> UserPermissionCategoryMappings { get; }
        IRepository<RetailerUserPermissionCategoryMapping> RetailerUserPermissionCategoryMappings { get; }
        IRepository<OrderAdvShipNotice> OrderAdvShipNotices { get; }
        IRepository<OrderAdvShipNoticeDetail> OrderAdvShipNoticeDetails { get; }
        IRepository<OrderInvoice> OrderInvoices { get; }
        IRepository<OrderInvoiceDetail> OrderInvoiceDetails { get; }
        IRepository<OrderInvoiceCharge> OrderInvoiceCharges { get; }
        IRepository<UserPasswordHistory> UserPasswordHistories { get; }
        IRepository<RetailerOrganization> RetailerOrganizations { get; }
        IRepository<RetailerUserMapping> RetailerUserMappings { get; }
        IRepository<RetailerStatusChangeHistory> RetailerStatusChangeHistories { get; }
        IRepository<DeliveryScheduleDocument> DeliveryScheduleDocuments { get; }
        IRepository<DeliverySchedule> DeliverySchedules { get; }
        IRepository<DeliveryScheduleTemp> DeliveryScheduleTemps { get; }
        IRepository<CustomerTransactionsD365> CustomerTransactionsD365 { get; }
        IRepository<MainOrderStatusMaster> MainOrderStatusMasters { get; }
        IRepository<ExceptionLog> ExceptionLogs { get; }
        IRepository<RetailerLastOrderedItem> RetailerLastOrderedItems { get; }
        IRepository<CarouselDetail> CarouselDetails { get; }
        IRepository<D365CustomerGroupMaster> D365CustomerGroupMasters { get; }
        IRepository<D365LanguageMaster> D365LanguageMasters { get; }
        IRepository<D365ChargeGroupMaster> D365ChargeGroupMasters { get; }
        IRepository<D365SiteMaster> D365SiteMasters { get; }
        IRepository<D365WarehouseMaster> D365WarehouseMasters { get; }
        IRepository<D365SalesPoolMaster> D365SalesPoolMasters { get; }
        IRepository<D365PriceMaster> D365PriceMasters { get; }
        IRepository<D365TermsOfPaymentMaster> D365TermsOfPaymentMasters { get; }
        IRepository<D365MethodOfPaymentMaster> D365MethodOfPaymentMasters { get; }
        IRepository<D365DeliveryTermsMaster> D365DeliveryTermsMasters { get; }
        IRepository<D365ModeOfDeliveryMaster> D365ModeOfDeliveryMasters { get; }
        IRepository<D365SalesTaxGroupMaster> D365SalesTaxGroupMasters { get; }
        IRepository<D365PriceIncludesSalesTaxMaster> D365PriceIncludesSalesTaxMasters { get; }
        IRepository<D365InvoicingAndDeliveryOnHoldMaster> D365InvoicingAndDeliveryOnHoldMasters { get; }
        IRepository<UserLoginHistory> UserLoginHistories { get; }
        IRepository<RetailerOnStockNotification> RetailerOnStockNotifications { get; }
        IRepository<FavouriteItems> FavouriteItems { get; }
        //IRepository<ChangeType> ChangeTypes { get; }
        IRepository<ChangeHistory> ChangeHistories { get; }
        IRepository<AuditHistory> AuditHistories { get; }
        IRepository<ActionTypeMaster> ActionTypeMasters { get; }
        IRepository<HomePageTemplateMaster> HomePageTemplateMasters { get; }
        IRepository<HomePage> HomePages { get; }
        IRepository<HomePageCTA> HomePageCTAs { get; }
        IRepository<HomePageContentBlock> HomePageContentBlocks { get; }
        //IRepository<HomePagePredefinedLinkMaster> HomePagePredefinedLinkMasters { get; }
        IRepository<HomePageTemplateCTAMaster> HomePageTemplateCTAMasters { get; }
        IRepository<HomePageTemplateContentBlockMaster> HomePageTemplateContentBlockMasters { get; }
        IRepository<HomePageTemplateCTAMapping> HomePageTemplateCTAMappings { get; }
        IRepository<HomePageTemplateContentBlockMapping> HomePageTemplateContentBlockMappings { get; }
        IRepository<HomePageRetailerGroupMaping> HomePageRetailerGroupMaping { get; }
        IRepository<HomePageFooter> HomePageFooters { get; }
        IRepository<HomePageFooterLink> HomePageFooterLinks { get; }
        IRepository<FontFamilyMaster> FontFamilyMasters { get; }
        IRepository<ContentAlignmentMaster> ContentAlignmentMasters { get; }
        IRepository<ImageAlignmentMaster> ImageAlignmentMasters { get; }

        IRepository<FontWeightMaster> FontWeightMasters { get; }
        IRepository<HomePagePredefinedActionMaster> HomePagePredefinedActionMasters { get; }
        IRepository<ContactTypeMaster> ContactTypeMasters { get; }
        IRepository<RetailerTypeMaster> RetailerTypeMasters { get; }
        IRepository<RetailerOrganizationContactInfo> RetailerOrganizationContactInfos { get; }
        IRepository<RetailerSavedFilter> RetailerSavedFilters { get; }
        IRepository<RetailerSavedFilterDetail> RetailerSavedFilterDetails { get; }
        IRepository<PDPFilterTypeMaster> PDPFilterTypeMasters { get; }

        IRepository<RelatedProductRuleDetail> RelatedProductRuleDetails { get; }
        IRepository<RelatedProductRule> RelatedProductRules { get; }
        IRepository<ProductRelationTypeMaster> ProductRelationTypeMasters { get; }
        IRepository<RelatedProductDataRuleAttributeMaster> RelatedProductDataRuleAttributeMasters { get; }
        IRepository<RelatedProductDataRuleAttributeSignMaster> RelatedProductDataRuleAttributeSignMasters { get; }
        IRepository<RelatedProductDataRuleAttributeTypeMaster> RelatedProductDataRuleAttributeTypeMasters { get; }
        IRepository<RelatedProductDataRuleLevelMaster> RelatedProductDataRuleLevelMasters { get; }
        IRepository<RelatedProductDataRuleSignMaster> RelatedProductDataRuleSignMasters { get; }
        IRepository<RelatedProduct> RelatedProducts { get; }
        IRepository<UserPreference> UserPreferences { get; }
    }
}
