using Games.DataModel;
using Games.IRepository;
using Games.IRepository.Unit;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Games.Repository.SQL.Unit
{
    public class MainUnit : BaseUnit, IMainUnit
    {
        protected override void Init()
        {
            base.Init();
            #region repositories
            _statuses = new GenericRepository<StatusMaster>(Set<StatusMaster>());
            _configurations = new GenericRepository<Config>(Set<Config>());
            _provinces = new GenericRepository<Province>(Set<Province>());
            _stores = new GenericRepository<Store>(Set<Store>());
            _userTypes = new GenericRepository<UserType>(Set<UserType>());
            _users = new GenericRepository<User>(Set<User>());

            _productTagCollections = new GenericRepository<ProductTagCollection>(Set<ProductTagCollection>());
            _productTagCollectionCategoryMasters = new GenericRepository<ProductTagCollectionCategoryMaster>(Set<ProductTagCollectionCategoryMaster>());

            _urlTokens = new GenericRepository<UrlToken>(Set<UrlToken>());
            _menuItems = new GenericRepository<MenuItemMaster>(Set<MenuItemMaster>());

            _locations = new GenericRepository<Location>(Set<Location>());
            _retailerGroups = new GenericRepository<RetailerGroup>(Set<RetailerGroup>());
            _retailers = new GenericRepository<Retailer>(Set<Retailer>());

            _emailTypeMasters = new GenericRepository<EmailTypeMaster>(Set<EmailTypeMaster>());
            _emailTemplates = new GenericRepository<EmailTemplate>(Set<EmailTemplate>());
            _resources = new GenericRepository<Resource>(Set<Resource>());

            _emailBlasts = new GenericRepository<EmailBlast>(Set<EmailBlast>());
            _emailBlastRetailers = new GenericRepository<EmailBlastRetailer>(Set<EmailBlastRetailer>());
            _emailBlastRetailerGroups = new GenericRepository<EmailBlastRetailerGroup>(Set<EmailBlastRetailerGroup>());
            _emailBlastDocuments = new GenericRepository<EmailBlastDocument>(Set<EmailBlastDocument>());

            _requestInfo = new GenericRepository<RequestInfo>(Set<RequestInfo>());
            _requestStatusMasters = new GenericRepository<RequestStatusMaster>(Set<RequestStatusMaster>());
            _requestTypeMasters = new GenericRepository<RequestTypeMaster>(Set<RequestTypeMaster>());
            _tokenTypeMasters = new GenericRepository<TokenTypeMaster>(Set<TokenTypeMaster>());
            _deliveryDoorAccessMasters = new GenericRepository<DeliveryDoorAccessMaster>(Set<DeliveryDoorAccessMaster>());
            _retailerStoreDetails = new GenericRepository<RetailerStoreDetail>(Set<RetailerStoreDetail>());
            _retailerStoreHours = new GenericRepository<RetailerStoreHours>(Set<RetailerStoreHours>());
            _dayMasters = new GenericRepository<DayMaster>(Set<DayMaster>());
            _emailNotificationLogs = new GenericRepository<EmailNotificationLog>(Set<EmailNotificationLog>());
            _userInfoStages = new GenericRepository<UserInfoStage>(Set<UserInfoStage>());

            _uploadDocuments = new GenericRepository<DocumentTypeMaster>(Set<DocumentTypeMaster>());
            _retailerStoreDocuments = new GenericRepository<RetailerStoreDocument>(Set<RetailerStoreDocument>());
            _retailerStatusMasters = new GenericRepository<RetailerStatusMaster>(Set<RetailerStatusMaster>());
            _entityTypeMasters = new GenericRepository<EntityTypeMaster>(Set<EntityTypeMaster>());
            _retailerAddresses = new GenericRepository<RetailerAddress>(Set<RetailerAddress>());
            _addressTypeMasters = new GenericRepository<AddressTypeMaster>(Set<AddressTypeMaster>());
            _retailerStoreDetail = new GenericRepository<RetailerStoreDetail>(Set<RetailerStoreDetail>());
            _retailerAddress = new GenericRepository<RetailerAddress>(Set<RetailerAddress>());
            _receivingLocationMasters = new GenericRepository<ReceivingLocationMaster>(Set<ReceivingLocationMaster>());
            _retailerStageStatuses = new GenericRepository<RetailerStageStatus>(Set<RetailerStageStatus>());
            _requestStatusChangeHistory = new GenericRepository<RequestStatusChangeHistory>(Set<RequestStatusChangeHistory>());
            _serviceCallLog = new GenericRepository<ServiceCallLog>(Set<ServiceCallLog>());
            _userRoles = new GenericRepository<UserRole>(Set<UserRole>());
            _colorPalletMasters = new GenericRepository<ColorPalletMaster>(Set<ColorPalletMaster>());
            _PermissionCategories = new GenericRepository<PermissionCategoryMaster>(Set<PermissionCategoryMaster>());
            _UserRolePermissionCategories = new GenericRepository<UserRolePermissionCategory>(Set<UserRolePermissionCategory>());
            _permissionMasters = new GenericRepository<PermissionMaster>(Set<PermissionMaster>());
            _menuItemPermissions = new GenericRepository<MenuItemPermission>(Set<MenuItemPermission>());
            _userRolePermissionCategoryMappedRoles = new GenericRepository<UserRolePermissionCategoryMappedRole>(Set<UserRolePermissionCategoryMappedRole>());
            _itemCategoryMasters = new GenericRepository<ItemCategoryMaster>(Set<ItemCategoryMaster>());
            _itemSubCategoryMasters = new GenericRepository<ItemSubCategoryMaster>(Set<ItemSubCategoryMaster>());
            _itemSubSubCategoryMasters = new GenericRepository<ItemSubSubCategoryMaster>(Set<ItemSubSubCategoryMaster>());
            _items = new GenericRepository<Item>(Set<Item>());
            _itemPlantTypeSpeciesMasters = new GenericRepository<ItemPlantTypeSpeciesMaster>(Set<ItemPlantTypeSpeciesMaster>());
            _itemSKUDetailExtensions = new GenericRepository<ItemSKUDetailExtension>(Set<ItemSKUDetailExtension>());
            _itemSKUDetails = new GenericRepository<ItemSKUDetail>(Set<ItemSKUDetail>());
            _itemImages = new GenericRepository<ItemImage>(Set<ItemImage>());
            _itemColorMasters = new GenericRepository<ItemColorMaster>(Set<ItemColorMaster>());
            _productTags = new GenericRepository<ProductTag>(Set<ProductTag>());
            _productTagItems = new GenericRepository<ProductTagItem>(Set<ProductTagItem>());
            _itemTerpeneMasters = new GenericRepository<ItemTerpeneMaster>(Set<ItemTerpeneMaster>());
            _productTagTypeMasters = new GenericRepository<ProductTagTypeMaster>(Set<ProductTagTypeMaster>());
            //_itemImages = new GenericRepository<ItemImage>(Set<ItemImage>());
            _productTagCollectionMappings = new GenericRepository<ProductTagCollectionMapping>(Set<ProductTagCollectionMapping>());
            _itemAttributeMasters = new GenericRepository<ItemAttributeMaster>(Set<ItemAttributeMaster>());
            _itemAttributes = new GenericRepository<ItemAttribute>(Set<ItemAttribute>());
            _pdpItemAttributeCategoryMasters = new GenericRepository<PDPItemAttributeCategoryMaster>(Set<PDPItemAttributeCategoryMaster>());
            _pdpItemAttributeMasters = new GenericRepository<PDPItemAttributeMaster>(Set<PDPItemAttributeMaster>());
            _itemRelationDatas = new GenericRepository<ItemRelationData>(Set<ItemRelationData>());
            _favouriteItems = new GenericRepository<FavouriteItems>(Set<FavouriteItems>());

            #region STORED PROCEDURES - PLEASE DO NOT TOUCH !!!
            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.SqlServer")
            {
                _spGetTaggedProducts = new RepositoryFromSql(Database.GetDbConnection().ConnectionString);
            }
            #endregion

            _productTagDataRules = new GenericRepository<ProductTagDataRule>(Set<ProductTagDataRule>());
            _productTagDataRuleAttributes = new GenericRepository<ProductTagDataRuleAttribute>(Set<ProductTagDataRuleAttribute>());
            _productTagDataRuleAttributeSigns = new GenericRepository<ProductTagDataRuleAttributeSign>(Set<ProductTagDataRuleAttributeSign>());


            _productTagDataRuleAttributeType = new GenericRepository<ProductTagDataRuleAttributeType>(Set<ProductTagDataRuleAttributeType>());
            _productTagDataRuleLevels = new GenericRepository<ProductTagDataRuleLevel>(Set<ProductTagDataRuleLevel>());


            _productTagDataRuleSigns = new GenericRepository<ProductTagDataRuleSign>(Set<ProductTagDataRuleSign>());
            _itemSubSubCategoryMasters = new GenericRepository<ItemSubSubCategoryMaster>(Set<ItemSubSubCategoryMaster>());
            _orderDetailTemps = new GenericRepository<OrderDetailTemp>(Set<OrderDetailTemp>());
            _orderItemDetailTemps = new GenericRepository<OrderItemDetailTemp>(Set<OrderItemDetailTemp>());
            _orderItemSKUDetailTemps = new GenericRepository<OrderItemSKUDetailTemp>(Set<OrderItemSKUDetailTemp>());
            _orderDetails = new GenericRepository<OrderDetail>(Set<OrderDetail>());
            _orderItemDetails = new GenericRepository<OrderItemDetail>(Set<OrderItemDetail>());
            _orderItemSKUDetails = new GenericRepository<OrderItemSKUDetail>(Set<OrderItemSKUDetail>());

            _banners = new GenericRepository<Banner>(Set<Banner>());
            _carouselbanners = new GenericRepository<CarouselBanner>(Set<CarouselBanner>());
            _reportissues = new GenericRepository<ReportIssue>(Set<ReportIssue>());
            _bannerColours = new GenericRepository<BannerColour>(Set<BannerColour>());
            _bannerRetailerGroups = new GenericRepository<BannerRetailerGroup>(Set<BannerRetailerGroup>());
            _webPages = new GenericRepository<WebPage>(Set<WebPage>());
            _bannerWebPages = new GenericRepository<BannerWebPage>(Set<BannerWebPage>());
            // Home Page
            _homePageTemplateMasters = new GenericRepository<HomePageTemplateMaster>(Set<HomePageTemplateMaster>());
            _homePages = new GenericRepository<HomePage>(Set<HomePage>());
            _homePageCTAs = new GenericRepository<HomePageCTA>(Set<HomePageCTA>());
            _homePageContentBlocks = new GenericRepository<HomePageContentBlock>(Set<HomePageContentBlock>());
            //_homePagePredefinedLinkMasters = new GenericRepository<HomePagePredefinedLinkMaster>(Set<HomePagePredefinedLinkMaster>());
            _homePageTemplateCTAMasters = new GenericRepository<HomePageTemplateCTAMaster>(Set<HomePageTemplateCTAMaster>());
            _homePageTemplateContentBlockMasters = new GenericRepository<HomePageTemplateContentBlockMaster>(Set<HomePageTemplateContentBlockMaster>());
            _homePageTemplateCTAMappings = new GenericRepository<HomePageTemplateCTAMapping>(Set<HomePageTemplateCTAMapping>());
            _homePageTemplateContentBlockMappings = new GenericRepository<HomePageTemplateContentBlockMapping>(Set<HomePageTemplateContentBlockMapping>());
            _homePageFooters = new GenericRepository<HomePageFooter>(Set<HomePageFooter>());
            _homePageFooterLinks = new GenericRepository<HomePageFooterLink>(Set<HomePageFooterLink>());

            _orderDetailTemps = new GenericRepository<OrderDetailTemp>(Set<OrderDetailTemp>());
            _orderItemDetailTemps = new GenericRepository<OrderItemDetailTemp>(Set<OrderItemDetailTemp>());
            _orderItemSKUDetailTemps = new GenericRepository<OrderItemSKUDetailTemp>(Set<OrderItemSKUDetailTemp>());
            _bannerStatusMasters = new GenericRepository<BannerStatusMaster>(Set<BannerStatusMaster>());

            _retailerRetailerGroups = new GenericRepository<RetailerRetailerGroup>(Set<RetailerRetailerGroup>());
            _devisorTypeMasters = new GenericRepository<DivisorTypeMaster>(Set<DivisorTypeMaster>());
            _sKUClassificationProductMappings = new GenericRepository<SKUClassificationProductMapping>(Set<SKUClassificationProductMapping>());
            _sKUClassifications = new GenericRepository<SKUClassification>(Set<SKUClassification>());

            _orderingDayConfigs = new GenericRepository<OrderingDayConfig>(Set<OrderingDayConfig>());
            _orderingDayConfigRetailerGroupMappings = new GenericRepository<OrderingDayConfigRetailerGroupMapping>(Set<OrderingDayConfigRetailerGroupMapping>());
            _orderStatuses = new GenericRepository<OrderStatusMaster>(Set<OrderStatusMaster>());
            _orderTotalRanges = new GenericRepository<OrderTotalRangeMaster>(Set<OrderTotalRangeMaster>());
            _notificationMasters = new GenericRepository<NotificationMaster>(Set<NotificationMaster>());
            _userNotificationMappings = new GenericRepository<UserNotificationMapping>(Set<UserNotificationMapping>());
            _holidayMasters = new GenericRepository<HolidayMaster>(Set<HolidayMaster>());
            _userPermissionCategoryMappings = new GenericRepository<UserPermissionCategoryMapping>(Set<UserPermissionCategoryMapping>());
            _retailerUserPermissionCategoryMappings = new GenericRepository<RetailerUserPermissionCategoryMapping>(Set<RetailerUserPermissionCategoryMapping>());
            _orderAdvShipNotices = new GenericRepository<OrderAdvShipNotice>(Set<OrderAdvShipNotice>());
            _orderAdvShipNoticeDetails = new GenericRepository<OrderAdvShipNoticeDetail>(Set<OrderAdvShipNoticeDetail>());
            _orderInvoices = new GenericRepository<OrderInvoice>(Set<OrderInvoice>());
            _orderInvoiceDetails = new GenericRepository<OrderInvoiceDetail>(Set<OrderInvoiceDetail>());
            _orderInvoiceCharges = new GenericRepository<OrderInvoiceCharge>(Set<OrderInvoiceCharge>());
            _userPasswordHistories = new GenericRepository<UserPasswordHistory>(Set<UserPasswordHistory>());
            _retailerOrganizations = new GenericRepository<RetailerOrganization>(Set<RetailerOrganization>());
            _retailerUserMappings = new GenericRepository<RetailerUserMapping>(Set<RetailerUserMapping>());
            _retailerStatusChangeHistories = new GenericRepository<RetailerStatusChangeHistory>(Set<RetailerStatusChangeHistory>());
            _deliveryScheduleDocuments = new GenericRepository<DeliveryScheduleDocument>(Set<DeliveryScheduleDocument>());
            _deliverySchedules = new GenericRepository<DeliverySchedule>(Set<DeliverySchedule>());
            _deliveryScheduleTemps = new GenericRepository<DeliveryScheduleTemp>(Set<DeliveryScheduleTemp>());
            _customerTransactionsD365 = new GenericRepository<CustomerTransactionsD365>(Set<CustomerTransactionsD365>());
            _mainOrderStatuses = new GenericRepository<MainOrderStatusMaster>(Set<MainOrderStatusMaster>());
            _exceptionLogs = new GenericRepository<ExceptionLog>(Set<ExceptionLog>());
            _retailerLastOrderedItems = new GenericRepository<RetailerLastOrderedItem>(Set<RetailerLastOrderedItem>());
            _carouselDetails = new GenericRepository<CarouselDetail>(Set<CarouselDetail>());
            _d365CustomerGroupMasters = new GenericRepository<D365CustomerGroupMaster>(Set<D365CustomerGroupMaster>());
            _d365LanguageMasters = new GenericRepository<D365LanguageMaster>(Set<D365LanguageMaster>());
            _d365ChargeGroupMasters = new GenericRepository<D365ChargeGroupMaster>(Set<D365ChargeGroupMaster>());
            _d365SiteMasters = new GenericRepository<D365SiteMaster>(Set<D365SiteMaster>());
            _d365WarehouseMasters = new GenericRepository<D365WarehouseMaster>(Set<D365WarehouseMaster>());
            _d365SalesPoolMasters = new GenericRepository<D365SalesPoolMaster>(Set<D365SalesPoolMaster>());
            _d365PriceMasters = new GenericRepository<D365PriceMaster>(Set<D365PriceMaster>());
            _d365TermsOfPaymentMasters = new GenericRepository<D365TermsOfPaymentMaster>(Set<D365TermsOfPaymentMaster>());
            _d365MethodOfPaymentMasters = new GenericRepository<D365MethodOfPaymentMaster>(Set<D365MethodOfPaymentMaster>());
            _d365DeliveryTermsMasters = new GenericRepository<D365DeliveryTermsMaster>(Set<D365DeliveryTermsMaster>());
            _d365ModeOfDeliveryMasters = new GenericRepository<D365ModeOfDeliveryMaster>(Set<D365ModeOfDeliveryMaster>());
            _d365SalesTaxGroupMasters = new GenericRepository<D365SalesTaxGroupMaster>(Set<D365SalesTaxGroupMaster>());
            _d365PriceIncludesSalesTaxMasters = new GenericRepository<D365PriceIncludesSalesTaxMaster>(Set<D365PriceIncludesSalesTaxMaster>());
            _d365InvoicingAndDeliveryOnHoldMasters = new GenericRepository<D365InvoicingAndDeliveryOnHoldMaster>(Set<D365InvoicingAndDeliveryOnHoldMaster>());
            _userLoginHistories = new GenericRepository<UserLoginHistory>(Set<UserLoginHistory>());
            _retailerOnStockNotifications = new GenericRepository<RetailerOnStockNotification>(Set<RetailerOnStockNotification>());

            //_changeTypes = new GenericRepository<ChangeType>(Set<ChangeType>());
            _changeHistories = new GenericRepository<ChangeHistory>(Set<ChangeHistory>());
            _auditHistories = new GenericRepository<AuditHistory>(Set<AuditHistory>());
            _actionTypeMasters = new GenericRepository<ActionTypeMaster>(Set<ActionTypeMaster>());
            _homePages = new GenericRepository<HomePage>(Set<HomePage>());
            _homePageRetailerGroups = new GenericRepository<HomePageRetailerGroupMaping>(Set<HomePageRetailerGroupMaping>());

            _fontFamilyMasters = new GenericRepository<FontFamilyMaster>(Set<FontFamilyMaster>());

            _contentAlignmentMaster = new GenericRepository<ContentAlignmentMaster>(Set<ContentAlignmentMaster>());
            _imagetAlignmentMaster = new GenericRepository<ImageAlignmentMaster>(Set<ImageAlignmentMaster>());




            _fontWeightMasters = new GenericRepository<FontWeightMaster>(Set<FontWeightMaster>());
            _homePagePredefinedActionMasters = new GenericRepository<HomePagePredefinedActionMaster>(Set<HomePagePredefinedActionMaster>());
            _contactTypeMasters = new GenericRepository<ContactTypeMaster>(Set<ContactTypeMaster>());
            _retailerTypeMasters = new GenericRepository<RetailerTypeMaster>(Set<RetailerTypeMaster>());
            _retailerOrganizationContactInfos = new GenericRepository<RetailerOrganizationContactInfo>(Set<RetailerOrganizationContactInfo>());
            _retailerSavedFilters = new GenericRepository<RetailerSavedFilter>(Set<RetailerSavedFilter>());
            _retailerSavedFilterDetail = new GenericRepository<RetailerSavedFilterDetail>(Set<RetailerSavedFilterDetail>());
            _pdpFilterTypeMaster = new GenericRepository<PDPFilterTypeMaster>(Set<PDPFilterTypeMaster>());
            _relatedProductRuleDetails = new GenericRepository<RelatedProductRuleDetail>(Set<RelatedProductRuleDetail>());
            _relatedProductRules = new GenericRepository<RelatedProductRule>(Set<RelatedProductRule>());
            _productRelationTypeMasters = new GenericRepository<ProductRelationTypeMaster>(Set<ProductRelationTypeMaster>());
            _relatedProductDataRuleAttributeMasters = new GenericRepository<RelatedProductDataRuleAttributeMaster>(Set<RelatedProductDataRuleAttributeMaster>());
            _relatedProductDataRuleAttributeSignMasters = new GenericRepository<RelatedProductDataRuleAttributeSignMaster>(Set<RelatedProductDataRuleAttributeSignMaster>());
            _relatedProductDataRuleAttributeTypeMasters = new GenericRepository<RelatedProductDataRuleAttributeTypeMaster>(Set<RelatedProductDataRuleAttributeTypeMaster>());
            _relatedProductDataRuleLevelMasters = new GenericRepository<RelatedProductDataRuleLevelMaster>(Set<RelatedProductDataRuleLevelMaster>());
            _relatedProductDataRuleSignMasters = new GenericRepository<RelatedProductDataRuleSignMaster>(Set<RelatedProductDataRuleSignMaster>());
            _relatedProducts = new GenericRepository<RelatedProduct>(Set<RelatedProduct>());
            #endregion repositories
        }

        public MainUnit(string connection) : base(connection)
        {


        }

        public MainUnit(DbContextOptions options) : base(options)
        {

        }

        #region generics
        //public IDatabase Database => this.Database;
        private GenericRepository<RetailerOnStockNotification> _retailerOnStockNotifications;
        public IRepository<RetailerOnStockNotification> RetailerOnStockNotifications => _retailerOnStockNotifications;

        private GenericRepository<D365CustomerGroupMaster> _d365CustomerGroupMasters;
        public IRepository<D365CustomerGroupMaster> D365CustomerGroupMasters => _d365CustomerGroupMasters;

        private GenericRepository<D365LanguageMaster> _d365LanguageMasters;
        public IRepository<D365LanguageMaster> D365LanguageMasters => _d365LanguageMasters;

        private GenericRepository<D365ChargeGroupMaster> _d365ChargeGroupMasters;
        public IRepository<D365ChargeGroupMaster> D365ChargeGroupMasters => _d365ChargeGroupMasters;

        private GenericRepository<D365SiteMaster> _d365SiteMasters;
        public IRepository<D365SiteMaster> D365SiteMasters => _d365SiteMasters;

        private GenericRepository<D365WarehouseMaster> _d365WarehouseMasters;
        public IRepository<D365WarehouseMaster> D365WarehouseMasters => _d365WarehouseMasters;

        private GenericRepository<D365SalesPoolMaster> _d365SalesPoolMasters;
        public IRepository<D365SalesPoolMaster> D365SalesPoolMasters => _d365SalesPoolMasters;

        private GenericRepository<D365PriceMaster> _d365PriceMasters;
        public IRepository<D365PriceMaster> D365PriceMasters => _d365PriceMasters;

        private GenericRepository<D365TermsOfPaymentMaster> _d365TermsOfPaymentMasters;
        public IRepository<D365TermsOfPaymentMaster> D365TermsOfPaymentMasters => _d365TermsOfPaymentMasters;

        private GenericRepository<D365MethodOfPaymentMaster> _d365MethodOfPaymentMasters;
        public IRepository<D365MethodOfPaymentMaster> D365MethodOfPaymentMasters => _d365MethodOfPaymentMasters;

        private GenericRepository<D365DeliveryTermsMaster> _d365DeliveryTermsMasters;
        public IRepository<D365DeliveryTermsMaster> D365DeliveryTermsMasters => _d365DeliveryTermsMasters;
        
        private GenericRepository<D365ModeOfDeliveryMaster> _d365ModeOfDeliveryMasters;
        public IRepository<D365ModeOfDeliveryMaster> D365ModeOfDeliveryMasters => _d365ModeOfDeliveryMasters;

        private GenericRepository<D365SalesTaxGroupMaster> _d365SalesTaxGroupMasters;
        public IRepository<D365SalesTaxGroupMaster> D365SalesTaxGroupMasters => _d365SalesTaxGroupMasters;

        private GenericRepository<D365PriceIncludesSalesTaxMaster> _d365PriceIncludesSalesTaxMasters;
        public IRepository<D365PriceIncludesSalesTaxMaster> D365PriceIncludesSalesTaxMasters => _d365PriceIncludesSalesTaxMasters;
       
        private GenericRepository<D365InvoicingAndDeliveryOnHoldMaster> _d365InvoicingAndDeliveryOnHoldMasters;
        public IRepository<D365InvoicingAndDeliveryOnHoldMaster> D365InvoicingAndDeliveryOnHoldMasters => _d365InvoicingAndDeliveryOnHoldMasters;


        private GenericRepository<StatusMaster> _statuses;
        IRepository<StatusMaster> IMainUnit.Statuses => _statuses;
        private GenericRepository<PermissionCategoryMaster> _PermissionCategories;
        IRepository<PermissionCategoryMaster> IMainUnit.PermissionCategory => _PermissionCategories;
        private GenericRepository<UserRolePermissionCategory> _UserRolePermissionCategories;
        IRepository<UserRolePermissionCategory> IMainUnit.UserRolePermissionCategory => _UserRolePermissionCategories;
        private GenericRepository<User> _users;
        IRepository<User> IMainUnit.Users => _users;
        private GenericRepository<ProductTagCollectionCategoryMaster> _productTagCollectionCategoryMasters;
        IRepository<ProductTagCollectionCategoryMaster> IMainUnit.ProductTagCollectionCategoryMasters => _productTagCollectionCategoryMasters;

        private GenericRepository<ProductTagCollection> _productTagCollections;
        IRepository<ProductTagCollection> IMainUnit.ProductTagCollections => _productTagCollections;

        private IRepository<Config> _configurations;
        IRepository<Config> IMainUnit.Configurations => _configurations;
        private GenericRepository<UserType> _userTypes;
        IRepository<UserType> IMainUnit.UserTypes => _userTypes;
        private GenericRepository<Province> _provinces;
        IRepository<Province> IMainUnit.Provinces => _provinces;
        private GenericRepository<Store> _stores;
        IRepository<Store> IMainUnit.Stores => _stores;

        private GenericRepository<UrlToken> _urlTokens;
        IRepository<UrlToken> IMainUnit.UrlTokens => _urlTokens;
        private GenericRepository<MenuItemMaster> _menuItems;
        IRepository<MenuItemMaster> IMainUnit.MenuItemMasters => _menuItems;

        private GenericRepository<Location> _locations;
        IRepository<Location> IMainUnit.Locations => _locations;

        private GenericRepository<RetailerGroup> _retailerGroups;
        IRepository<RetailerGroup> IMainUnit.RetailerGroups => _retailerGroups;
        private GenericRepository<RetailerStoreDocument> _retailerStoreDocuments;
        IRepository<RetailerStoreDocument> IMainUnit.RetailerStoreDocuments => _retailerStoreDocuments;

        private GenericRepository<Retailer> _retailers;
        IRepository<Retailer> IMainUnit.Retailers => _retailers;
        private GenericRepository<Resource> _resources;
        public IRepository<Resource> Resources => _resources;

        private GenericRepository<RequestStatusMaster> _requestStatusMasters;
        IRepository<RequestStatusMaster> IMainUnit.RequestStatusMasters => _requestStatusMasters;

        private GenericRepository<RequestTypeMaster> _requestTypeMasters;
        IRepository<RequestTypeMaster> IMainUnit.RequestTypeMasters => _requestTypeMasters;

        private GenericRepository<EmailTemplate> _emailTemplates;
        IRepository<EmailTemplate> IMainUnit.EmailTemplates => _emailTemplates;

        private GenericRepository<RequestInfo> _requestInfo;
        IRepository<RequestInfo> IMainUnit.RequestInfo => _requestInfo;

        private GenericRepository<EmailTypeMaster> _emailTypeMasters;
        IRepository<EmailTypeMaster> IMainUnit.EmailTypeMasters => _emailTypeMasters;

        private GenericRepository<EmailNotificationLog> _emailNotificationLogs;
        IRepository<EmailNotificationLog> IMainUnit.EmailNotificationLogs => _emailNotificationLogs;
        private GenericRepository<UserInfoStage> _userInfoStages;
        public IRepository<UserInfoStage> UserInfoStages => _userInfoStages;

        private GenericRepository<EmailBlast> _emailBlasts;
        IRepository<EmailBlast> IMainUnit.EmailBlasts => _emailBlasts;
        private GenericRepository<EmailBlastRetailer> _emailBlastRetailers;
        IRepository<EmailBlastRetailer> IMainUnit.EmailBlastRetailers => _emailBlastRetailers;
        private GenericRepository<EmailBlastRetailerGroup> _emailBlastRetailerGroups;
        IRepository<EmailBlastRetailerGroup> IMainUnit.EmailBlastRetailerGroups => _emailBlastRetailerGroups;
        private GenericRepository<EmailBlastDocument> _emailBlastDocuments;
        IRepository<EmailBlastDocument> IMainUnit.EmailBlastDocuments => _emailBlastDocuments;

        private GenericRepository<DocumentTypeMaster> _uploadDocuments;
        IRepository<DocumentTypeMaster> IMainUnit.DocumentTypeMasters => _uploadDocuments;

        private GenericRepository<DeliveryDoorAccessMaster> _deliveryDoorAccessMasters;
        IRepository<DeliveryDoorAccessMaster> IMainUnit.DeliveryDoorAccessMasters => _deliveryDoorAccessMasters;

        private GenericRepository<RetailerOrganization> _retailerOrganizations;
        IRepository<RetailerOrganization> IMainUnit.RetailerOrganizations => _retailerOrganizations;

        private GenericRepository<RetailerUserMapping> _retailerUserMappings;
        IRepository<RetailerUserMapping> IMainUnit.RetailerUserMappings => _retailerUserMappings;


        private GenericRepository<RetailerStoreDetail> _retailerStoreDetails;
        IRepository<RetailerStoreDetail> IMainUnit.RetailerStoreDetails => _retailerStoreDetails;

        private GenericRepository<RetailerStoreHours> _retailerStoreHours;
        IRepository<RetailerStoreHours> IMainUnit.RetailerStoreHours => _retailerStoreHours;

        private GenericRepository<RetailerStatusMaster> _retailerStatusMasters;
        IRepository<RetailerStatusMaster> IMainUnit.RetailerStatusMasters => _retailerStatusMasters;

        private GenericRepository<DayMaster> _dayMasters;
        IRepository<DayMaster> IMainUnit.DayMasters => _dayMasters;
        private GenericRepository<RetailerAddress> _retailerAddresses;
        public IRepository<RetailerAddress> RetailerAddresses => _retailerAddresses;
        private GenericRepository<EntityTypeMaster> _entityTypeMasters;
        public IRepository<EntityTypeMaster> EntityTypeMasters => _entityTypeMasters;
        private GenericRepository<AddressTypeMaster> _addressTypeMasters;
        public IRepository<AddressTypeMaster> AddressTypeMasters => _addressTypeMasters;
        private GenericRepository<RetailerStoreDetail> _retailerStoreDetail;
        public IRepository<RetailerStoreDetail> RetailerStoreDetail => _retailerStoreDetail;

        private GenericRepository<RetailerAddress> _retailerAddress;

        private IRepository<RetailerAddress> RetailerAddress => _retailerAddress;

        private GenericRepository<ReceivingLocationMaster> _receivingLocationMasters;
        IRepository<ReceivingLocationMaster> IMainUnit.ReceivingLocationMaster => _receivingLocationMasters;

        private GenericRepository<TokenTypeMaster> _tokenTypeMasters;
        IRepository<TokenTypeMaster> IMainUnit.TokenTypeMasters => _tokenTypeMasters;
        private GenericRepository<RetailerStageStatus> _retailerStageStatuses;
        public IRepository<RetailerStageStatus> RetailerStageStatuses => _retailerStageStatuses;

        private GenericRepository<RequestStatusChangeHistory> _requestStatusChangeHistory;
        public IRepository<RequestStatusChangeHistory> RequestStatusChangeHistory => _requestStatusChangeHistory;
        private GenericRepository<ServiceCallLog> _serviceCallLog;
        public IRepository<ServiceCallLog> ServiceCallLog => _serviceCallLog;

        private GenericRepository<PermissionMaster> _permissionMasters;
        public IRepository<PermissionMaster> PermissionMaster => _permissionMasters;


        private GenericRepository<ColorPalletMaster> _colorPalletMasters;
        public IRepository<ColorPalletMaster> ColorPalletMaster => _colorPalletMasters;

        private GenericRepository<UserRole> _userRoles;
        IRepository<UserRole> IMainUnit.UserRole => _userRoles;
        private GenericRepository<MenuItemPermission> _menuItemPermissions;
        IRepository<MenuItemPermission> IMainUnit.MenuItemPermission => _menuItemPermissions;
        private GenericRepository<UserRolePermissionCategoryMappedRole> _userRolePermissionCategoryMappedRoles;
        IRepository<UserRolePermissionCategoryMappedRole> IMainUnit.UserRolePermissionCategoryMappedRoles => _userRolePermissionCategoryMappedRoles;

        private GenericRepository<ItemCategoryMaster> _itemCategoryMasters;
        IRepository<ItemCategoryMaster> IMainUnit.ItemCategoryMasters => _itemCategoryMasters;
        private GenericRepository<ItemSubCategoryMaster> _itemSubCategoryMasters;
        IRepository<ItemSubCategoryMaster> IMainUnit.ItemSubCategoryMasters => _itemSubCategoryMasters;
        private GenericRepository<ItemSubSubCategoryMaster> _itemSubSubCategoryMasters;
        IRepository<ItemSubSubCategoryMaster> IMainUnit.ItemSubSubCategoryMasters => _itemSubSubCategoryMasters;
        private GenericRepository<Item> _items;
        IRepository<Item> IMainUnit.Items => _items;
        private GenericRepository<ItemPlantTypeSpeciesMaster> _itemPlantTypeSpeciesMasters;
        IRepository<ItemPlantTypeSpeciesMaster> IMainUnit.ItemPlantTypeSpeciesMasters => _itemPlantTypeSpeciesMasters;

        private GenericRepository<ItemSKUDetailExtension> _itemSKUDetailExtensions;
        IRepository<ItemSKUDetailExtension> IMainUnit.ItemSKUDetailExtensions => _itemSKUDetailExtensions;
        private GenericRepository<ProductTag> _productTags;
        public IRepository<ProductTag> ProductTags => _productTags;
        private GenericRepository<ProductTagItem> _productTagItems;
        public IRepository<ProductTagItem> ProductTagItems => _productTagItems;
        private GenericRepository<ItemImage> _itemImages;
        public IRepository<ItemImage> ItemImages => _itemImages;

        private GenericRepository<ItemColorMaster> _itemColorMasters;
        IRepository<ItemColorMaster> IMainUnit.ItemColorMasters => _itemColorMasters;
        private GenericRepository<ItemSKUDetail> _itemSKUDetails;
        IRepository<ItemSKUDetail> IMainUnit.ItemSKUDetails => _itemSKUDetails;
        private GenericRepository<ItemTerpeneMaster> _itemTerpeneMasters;
        IRepository<ItemTerpeneMaster> IMainUnit.ItemTerpeneMasters => _itemTerpeneMasters;
        private GenericRepository<ProductTagTypeMaster> _productTagTypeMasters;
        public IRepository<ProductTagTypeMaster> ProductTagTypeMasters => _productTagTypeMasters;
        private GenericRepository<ProductTagCollectionMapping> _productTagCollectionMappings;
        public IRepository<ProductTagCollectionMapping> ProductTagCollectionMappings => _productTagCollectionMappings;

        private GenericRepository<ItemAttributeMaster> _itemAttributeMasters;
        public IRepository<ItemAttributeMaster> ItemAttributeMasters => _itemAttributeMasters;

        private GenericRepository<ItemAttribute> _itemAttributes;
        public IRepository<ItemAttribute> ItemAttributes => _itemAttributes;

        private GenericRepository<PDPItemAttributeCategoryMaster> _pdpItemAttributeCategoryMasters;
        public IRepository<PDPItemAttributeCategoryMaster> PDPItemAttributeCategoryMasters => _pdpItemAttributeCategoryMasters;

        private GenericRepository<PDPItemAttributeMaster> _pdpItemAttributeMasters;
        public IRepository<PDPItemAttributeMaster> PDPItemAttributes => _pdpItemAttributeMasters;
        private GenericRepository<ItemRelationData> _itemRelationDatas;
        public IRepository<ItemRelationData> ItemRelationDatas => _itemRelationDatas;
        private GenericRepository<FavouriteItems> _favouriteItems;
        public IRepository<FavouriteItems> FavouriteItems => _favouriteItems;

        #region STORED PROCEDURES
        private RepositoryFromSql _spGetTaggedProducts;
        public IRepositoryFromSql RepositoryFromSql => _spGetTaggedProducts;

        #endregion
        private GenericRepository<ProductTagDataRule> _productTagDataRules;
        public IRepository<ProductTagDataRule> ProductTagDataRules => _productTagDataRules;
        private GenericRepository<ProductTagDataRuleAttribute> _productTagDataRuleAttributes;
        public IRepository<ProductTagDataRuleAttribute> ProductTagDataRuleAttributes => _productTagDataRuleAttributes;
        private GenericRepository<ProductTagDataRuleAttributeSign> _productTagDataRuleAttributeSigns;
        public IRepository<ProductTagDataRuleAttributeSign> ProductTagDataRuleAttributeSigns => _productTagDataRuleAttributeSigns;
        private GenericRepository<ProductTagDataRuleAttributeType> _productTagDataRuleAttributeType;
        public IRepository<ProductTagDataRuleAttributeType> ProductTagDataRuleAttributeTypes => _productTagDataRuleAttributeType;
        private GenericRepository<ProductTagDataRuleLevel> _productTagDataRuleLevels;
        public IRepository<ProductTagDataRuleLevel> ProductTagDataRuleLevels => _productTagDataRuleLevels;
        private GenericRepository<ProductTagDataRuleSign> _productTagDataRuleSigns;
        public IRepository<ProductTagDataRuleSign> ProductTagDataRuleSigns => _productTagDataRuleSigns;

        private GenericRepository<OrderDetailTemp> _orderDetailTemps;
        public IRepository<OrderDetailTemp> OrderDetailTemps => _orderDetailTemps;
        private GenericRepository<OrderItemDetailTemp> _orderItemDetailTemps;
        public IRepository<OrderItemDetailTemp> orderItemDetailTemps => _orderItemDetailTemps;
        private GenericRepository<OrderItemSKUDetailTemp> _orderItemSKUDetailTemps;
        public IRepository<OrderItemSKUDetailTemp> orderItemSKUDetailTemps => _orderItemSKUDetailTemps;
        private GenericRepository<OrderDetail> _orderDetails;
        public IRepository<OrderDetail> OrderDetails => _orderDetails;
        private GenericRepository<OrderItemDetail> _orderItemDetails;
        public IRepository<OrderItemDetail> orderItemDetails => _orderItemDetails;
        private GenericRepository<OrderItemSKUDetail> _orderItemSKUDetails;
        public IRepository<OrderItemSKUDetail> orderItemSKUDetails => _orderItemSKUDetails;

        private GenericRepository<Banner> _banners;
        public IRepository<Banner> Banners => _banners;
        private GenericRepository<CarouselBanner> _carouselbanners;
        public IRepository<CarouselBanner> CarouselBanners => _carouselbanners;

        private GenericRepository<ReportIssue> _reportissues;
        public IRepository<ReportIssue> ReportIssues => _reportissues;

        // Home Page
        private GenericRepository<HomePageTemplateMaster> _homePageTemplateMasters;
        public IRepository<HomePageTemplateMaster> HomePageTemplateMasters => _homePageTemplateMasters;
        private GenericRepository<HomePage> _homePages;
        public IRepository<HomePage> HomePages => _homePages;
        private GenericRepository<HomePageCTA> _homePageCTAs;
        public IRepository<HomePageCTA> HomePageCTAs => _homePageCTAs;
        private GenericRepository<HomePageContentBlock> _homePageContentBlocks;
        public IRepository<HomePageContentBlock> HomePageContentBlocks => _homePageContentBlocks;
        //private GenericRepository<HomePagePredefinedLinkMaster> _homePagePredefinedLinkMasters;
        //public IRepository<HomePagePredefinedLinkMaster> HomePagePredefinedLinkMasters => _homePagePredefinedLinkMasters;
        private GenericRepository<HomePageTemplateCTAMaster> _homePageTemplateCTAMasters;
        public IRepository<HomePageTemplateCTAMaster> HomePageTemplateCTAMasters => _homePageTemplateCTAMasters;
        private GenericRepository<HomePageTemplateContentBlockMaster> _homePageTemplateContentBlockMasters;
        public IRepository<HomePageTemplateContentBlockMaster> HomePageTemplateContentBlockMasters => _homePageTemplateContentBlockMasters;
        private GenericRepository<HomePageTemplateCTAMapping> _homePageTemplateCTAMappings;
        public IRepository<HomePageTemplateCTAMapping> HomePageTemplateCTAMappings => _homePageTemplateCTAMappings;
        private GenericRepository<HomePageTemplateContentBlockMapping> _homePageTemplateContentBlockMappings;
        public IRepository<HomePageTemplateContentBlockMapping> HomePageTemplateContentBlockMappings => _homePageTemplateContentBlockMappings;
        private GenericRepository<HomePageFooter> _homePageFooters;
        public IRepository<HomePageFooter> HomePageFooters => _homePageFooters;
        private GenericRepository<HomePageFooterLink> _homePageFooterLinks;
        public IRepository<HomePageFooterLink> HomePageFooterLinks => _homePageFooterLinks;

        private GenericRepository<BannerColour> _bannerColours;
        public IRepository<BannerColour> BannerColours => _bannerColours;
        private GenericRepository<BannerRetailerGroup> _bannerRetailerGroups;
        public IRepository<BannerRetailerGroup> BannerRetailerGroups => _bannerRetailerGroups;
        private GenericRepository<WebPage> _webPages;
        public IRepository<WebPage> WebPages => _webPages;
        private GenericRepository<BannerWebPage> _bannerWebPages;
        public IRepository<BannerWebPage> BannerWebPages => _bannerWebPages;

        private GenericRepository<BannerStatusMaster> _bannerStatusMasters;
        public IRepository<BannerStatusMaster> BannerStatusMasters => _bannerStatusMasters;


        public IRepository<OrderItemDetailTemp> OrderItemDetailTemps => _orderItemDetailTemps;

        public IRepository<OrderItemSKUDetailTemp> OrderItemSKUDetailTemps => _orderItemSKUDetailTemps;

        public IRepository<OrderItemDetail> OrderItemDetails => _orderItemDetails;

        public IRepository<OrderItemSKUDetail> OrderItemSKUDetails => _orderItemSKUDetails;

        private GenericRepository<RetailerRetailerGroup> _retailerRetailerGroups;
        public IRepository<RetailerRetailerGroup> RetailerRetailerGroups => _retailerRetailerGroups;
        private GenericRepository<DivisorTypeMaster> _devisorTypeMasters;
        public IRepository<DivisorTypeMaster> DivisorTypeMasters => _devisorTypeMasters;
        private GenericRepository<SKUClassification> _sKUClassifications;
        public IRepository<SKUClassification> SKUClassifications => _sKUClassifications;
        private GenericRepository<SKUClassificationProductMapping> _sKUClassificationProductMappings;
        public IRepository<SKUClassificationProductMapping> SKUClassificationProductMappings => _sKUClassificationProductMappings;


        private GenericRepository<OrderingDayConfig> _orderingDayConfigs;
        public IRepository<OrderingDayConfig> OrderingDayConfigs => _orderingDayConfigs;

        private GenericRepository<OrderingDayConfigRetailerGroupMapping> _orderingDayConfigRetailerGroupMappings;
        public IRepository<OrderingDayConfigRetailerGroupMapping> OrderingDayConfigRetailerGroupMappings => _orderingDayConfigRetailerGroupMappings;

        private GenericRepository<OrderStatusMaster> _orderStatuses;
        public IRepository<OrderStatusMaster> OrderStatuses => _orderStatuses;

        private GenericRepository<OrderTotalRangeMaster> _orderTotalRanges;
        public IRepository<OrderTotalRangeMaster> OrderTotalRanges => _orderTotalRanges;
        private GenericRepository<NotificationMaster> _notificationMasters;
        public IRepository<NotificationMaster> NotificationMasters => _notificationMasters;
        private GenericRepository<UserNotificationMapping> _userNotificationMappings;
        public IRepository<UserNotificationMapping> UserNotificationMappings => _userNotificationMappings;
        private GenericRepository<HolidayMaster> _holidayMasters;
        public IRepository<HolidayMaster> HolidayMasters => _holidayMasters;
        private GenericRepository<UserPermissionCategoryMapping> _userPermissionCategoryMappings;
        public IRepository<UserPermissionCategoryMapping> UserPermissionCategoryMappings => _userPermissionCategoryMappings;
        private GenericRepository<RetailerUserPermissionCategoryMapping> _retailerUserPermissionCategoryMappings;
        public IRepository<RetailerUserPermissionCategoryMapping> RetailerUserPermissionCategoryMappings => _retailerUserPermissionCategoryMappings;
        private GenericRepository<OrderAdvShipNotice> _orderAdvShipNotices;
        public IRepository<OrderAdvShipNotice> OrderAdvShipNotices => _orderAdvShipNotices;
        private GenericRepository<OrderAdvShipNoticeDetail> _orderAdvShipNoticeDetails;
        public IRepository<OrderAdvShipNoticeDetail> OrderAdvShipNoticeDetails => _orderAdvShipNoticeDetails;
        private GenericRepository<OrderInvoice> _orderInvoices;
        public IRepository<OrderInvoice> OrderInvoices => _orderInvoices;
        private GenericRepository<OrderInvoiceDetail> _orderInvoiceDetails;
        public IRepository<OrderInvoiceDetail> OrderInvoiceDetails => _orderInvoiceDetails;
        private GenericRepository<OrderInvoiceCharge> _orderInvoiceCharges;
        public IRepository<OrderInvoiceCharge> OrderInvoiceCharges => _orderInvoiceCharges;
        private GenericRepository<UserPasswordHistory> _userPasswordHistories;
        public IRepository<UserPasswordHistory> UserPasswordHistories => _userPasswordHistories;
        private GenericRepository<RetailerStatusChangeHistory> _retailerStatusChangeHistories;
        public IRepository<RetailerStatusChangeHistory> RetailerStatusChangeHistories => _retailerStatusChangeHistories;

        private GenericRepository<DeliveryScheduleDocument> _deliveryScheduleDocuments;
        public IRepository<DeliveryScheduleDocument> DeliveryScheduleDocuments => _deliveryScheduleDocuments;

        private GenericRepository<DeliverySchedule> _deliverySchedules;
        public IRepository<DeliverySchedule> DeliverySchedules => _deliverySchedules;
        
        private GenericRepository<DeliveryScheduleTemp> _deliveryScheduleTemps;
        public IRepository<DeliveryScheduleTemp> DeliveryScheduleTemps => _deliveryScheduleTemps;

        private GenericRepository<CustomerTransactionsD365> _customerTransactionsD365;
        public IRepository<CustomerTransactionsD365> CustomerTransactionsD365 => _customerTransactionsD365;

        private GenericRepository<MainOrderStatusMaster> _mainOrderStatuses;
        IRepository<MainOrderStatusMaster> IMainUnit.MainOrderStatusMasters => _mainOrderStatuses;
        private GenericRepository<ExceptionLog> _exceptionLogs;
        public IRepository<ExceptionLog> ExceptionLogs => _exceptionLogs;

        private GenericRepository<RetailerLastOrderedItem> _retailerLastOrderedItems;
        public IRepository<RetailerLastOrderedItem> RetailerLastOrderedItems => _retailerLastOrderedItems;
        private GenericRepository<CarouselDetail> _carouselDetails;
        public IRepository<CarouselDetail> CarouselDetails => _carouselDetails;

        private GenericRepository<UserLoginHistory> _userLoginHistories;
        public IRepository<UserLoginHistory> UserLoginHistories => _userLoginHistories;

        //private GenericRepository<ItemSubSubCategoryMaster> _itemSubSubCategoryMasters;
        //public IRepository<ItemSubSubCategoryMaster> ItemSubSubCategoryMasters => _itemSubSubCategoryMasters;
        
        //private GenericRepository<ChangeType> _changeTypes;
        //public IRepository<ChangeType> ChangeTypes => _changeTypes;

        private GenericRepository<ChangeHistory> _changeHistories;
        public IRepository<ChangeHistory> ChangeHistories => _changeHistories;

        private GenericRepository<AuditHistory> _auditHistories;
        public IRepository<AuditHistory> AuditHistories => _auditHistories;
        private GenericRepository<ActionTypeMaster> _actionTypeMasters;
        public IRepository<ActionTypeMaster> ActionTypeMasters => _actionTypeMasters;
        private GenericRepository<HomePageRetailerGroupMaping> _homePageRetailerGroups;
        public IRepository<HomePageRetailerGroupMaping> HomePageRetailerGroupMaping => _homePageRetailerGroups;

        private GenericRepository<FontFamilyMaster> _fontFamilyMasters;
        public IRepository<FontFamilyMaster> FontFamilyMasters => _fontFamilyMasters;

        private GenericRepository<ContentAlignmentMaster> _contentAlignmentMaster;
        public IRepository<ContentAlignmentMaster> ContentAlignmentMasters => _contentAlignmentMaster;

        private GenericRepository<ImageAlignmentMaster> _imagetAlignmentMaster;
        public IRepository<ImageAlignmentMaster> ImageAlignmentMasters => _imagetAlignmentMaster;
        


        private GenericRepository<FontWeightMaster> _fontWeightMasters;
        public IRepository<FontWeightMaster> FontWeightMasters => _fontWeightMasters;
        private GenericRepository<HomePagePredefinedActionMaster> _homePagePredefinedActionMasters;
        public IRepository<HomePagePredefinedActionMaster> HomePagePredefinedActionMasters => _homePagePredefinedActionMasters;
        private GenericRepository<ContactTypeMaster> _contactTypeMasters;
        public IRepository<ContactTypeMaster> ContactTypeMasters => _contactTypeMasters;
        private GenericRepository<RetailerTypeMaster> _retailerTypeMasters;
        public IRepository<RetailerTypeMaster> RetailerTypeMasters => _retailerTypeMasters;
        private GenericRepository<RetailerOrganizationContactInfo> _retailerOrganizationContactInfos;
        public IRepository<RetailerOrganizationContactInfo> RetailerOrganizationContactInfos => _retailerOrganizationContactInfos;

        private GenericRepository<RetailerSavedFilter> _retailerSavedFilters;
        public IRepository<RetailerSavedFilter> RetailerSavedFilters => _retailerSavedFilters;

        private GenericRepository<RetailerSavedFilterDetail> _retailerSavedFilterDetail;
        public IRepository<RetailerSavedFilterDetail> RetailerSavedFilterDetails => _retailerSavedFilterDetail;

        private GenericRepository<PDPFilterTypeMaster> _pdpFilterTypeMaster;
        public IRepository<PDPFilterTypeMaster> PDPFilterTypeMasters => _pdpFilterTypeMaster;

        private GenericRepository<RelatedProductRuleDetail> _relatedProductRuleDetails;
        public IRepository<RelatedProductRuleDetail> RelatedProductRuleDetails => _relatedProductRuleDetails;
        private GenericRepository<RelatedProductRule> _relatedProductRules;
        public IRepository<RelatedProductRule> RelatedProductRules => _relatedProductRules;
        private GenericRepository<ProductRelationTypeMaster> _productRelationTypeMasters;
        public IRepository<ProductRelationTypeMaster> ProductRelationTypeMasters => _productRelationTypeMasters;
        private GenericRepository<RelatedProductDataRuleAttributeMaster> _relatedProductDataRuleAttributeMasters;
        public IRepository<RelatedProductDataRuleAttributeMaster> RelatedProductDataRuleAttributeMasters => _relatedProductDataRuleAttributeMasters;
        private GenericRepository<RelatedProductDataRuleAttributeSignMaster> _relatedProductDataRuleAttributeSignMasters;
        public IRepository<RelatedProductDataRuleAttributeSignMaster> RelatedProductDataRuleAttributeSignMasters => _relatedProductDataRuleAttributeSignMasters;
        private GenericRepository<RelatedProductDataRuleAttributeTypeMaster> _relatedProductDataRuleAttributeTypeMasters;
        public IRepository<RelatedProductDataRuleAttributeTypeMaster> RelatedProductDataRuleAttributeTypeMasters => _relatedProductDataRuleAttributeTypeMasters;
        private GenericRepository<RelatedProductDataRuleLevelMaster> _relatedProductDataRuleLevelMasters;
        public IRepository<RelatedProductDataRuleLevelMaster> RelatedProductDataRuleLevelMasters => _relatedProductDataRuleLevelMasters;
        private GenericRepository<RelatedProductDataRuleSignMaster> _relatedProductDataRuleSignMasters;
        public IRepository<RelatedProductDataRuleSignMaster> RelatedProductDataRuleSignMasters => _relatedProductDataRuleSignMasters;
        private GenericRepository<RelatedProduct> _relatedProducts;
        public IRepository<RelatedProduct> RelatedProducts => _relatedProducts;
        private GenericRepository<UserPreference> _userPreferences;
        public IRepository<UserPreference> UserPreferences => _userPreferences;
        #endregion generics

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connection);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //CONFIG - STATUS
            modelBuilder.Entity<Config>().HasOne(c => c.Status).WithMany().HasForeignKey(c => c.StatusId);
            //PROVINCE - STATUS
            modelBuilder.Entity<Province>().HasOne(p => p.Status).WithMany().HasForeignKey(p => p.StatusId);
            //USERTYPE - STATUS
            modelBuilder.Entity<UserType>().HasOne(ut => ut.Status).WithMany().HasForeignKey(ut => ut.StatusId);
            //STORE - STATUS
            //modelBuilder.Entity<Store>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            //STORE - PROVINCE
            //modelBuilder.Entity<Store>().HasOne(s => s.Province).WithMany().HasForeignKey(s => s.ProvinceId);
            //DeliveryDoorAccessMaster - Status
            modelBuilder.Entity<DeliveryDoorAccessMaster>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            //RetailerStoreDetails - DeliveryDoorAccess
            modelBuilder.Entity<RetailerStoreDetail>().HasOne(s => s.DeliveryDoorAccess).WithMany().HasForeignKey(s => s.DeliveryDoorAccessID);
            //RetailerStoreDetails - Location
            modelBuilder.Entity<RetailerStoreDetail>().HasOne(s => s.ReceivingLocation).WithMany().HasForeignKey(s => s.ReceivingLocationID);
            //RetailerStoreHours - Retailer
            modelBuilder.Entity<RetailerStoreHours>().HasOne(s => s.Retailer).WithMany().HasForeignKey(s => s.RetailerId);
            //RetailerStoreHours - Store
            modelBuilder.Entity<RetailerStoreHours>().HasOne(s => s.Store).WithMany().HasForeignKey(s => s.StoreId);
            //RetailerStoreHours - Status
            modelBuilder.Entity<RetailerStoreHours>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            //DayMaster - Status
            modelBuilder.Entity<DayMaster>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusID);
            //RetailerAddress - Status
            modelBuilder.Entity<RetailerAddress>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            //RetailerAddress - Province
            modelBuilder.Entity<RetailerAddress>().HasOne(s => s.Province).WithMany().HasForeignKey(s => s.ProvinceId);
            //ReceivingLocationMaster - Status
            modelBuilder.Entity<ReceivingLocationMaster>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusID);
            modelBuilder.Entity<TokenTypeMaster>();
            modelBuilder.Entity<RetailerOnStockNotification>();
            modelBuilder.Entity<ServiceCallLog>();
            modelBuilder.Entity<ColorPalletMaster>();
            modelBuilder.Entity<PermissionCategoryMaster>();
            modelBuilder.Entity<HolidayMaster>();
            modelBuilder.Entity<ItemTerpeneMaster>();
            modelBuilder.Entity<ItemRelationData>();
            modelBuilder.Entity<OrderAdvShipNotice>();
            modelBuilder.Entity<OrderAdvShipNoticeDetail>();
            modelBuilder.Entity<OrderInvoice>();
            modelBuilder.Entity<OrderInvoiceDetail>();
            modelBuilder.Entity<OrderInvoiceCharge>();
            modelBuilder.Entity<RetailerLastOrderedItem>();
            modelBuilder.Entity<CarouselDetail>();
            modelBuilder.Entity<D365CustomerGroupMaster>();
            modelBuilder.Entity<D365LanguageMaster>();
            modelBuilder.Entity<D365ChargeGroupMaster>();
            modelBuilder.Entity<D365SiteMaster>();
            modelBuilder.Entity<D365WarehouseMaster>();
            modelBuilder.Entity<D365SalesPoolMaster>();
            modelBuilder.Entity<D365PriceMaster>();
            modelBuilder.Entity<D365TermsOfPaymentMaster>();
            modelBuilder.Entity<D365MethodOfPaymentMaster>();
            modelBuilder.Entity<D365DeliveryTermsMaster>();
            modelBuilder.Entity<D365ModeOfDeliveryMaster>();
            modelBuilder.Entity<D365SalesTaxGroupMaster>();
            modelBuilder.Entity<D365PriceIncludesSalesTaxMaster>();
            modelBuilder.Entity<D365InvoicingAndDeliveryOnHoldMaster>();
            modelBuilder.Entity<FavouriteItems>();
            modelBuilder.Entity<ReportIssue>();
            modelBuilder.Entity<EmailBlast>();
            modelBuilder.Entity<EmailBlastDocument>();
            modelBuilder.Entity<EmailBlastRetailer>();
            modelBuilder.Entity<EmailBlastRetailerGroup>();
            modelBuilder.Entity<AuditHistory>();
            modelBuilder.Entity<RetailerSavedFilter>()
                .HasOne(r => r.CreatedUser)
                .WithMany()
                .HasForeignKey("CreatedBy"); 
            //modelBuilder.Entity<RetailerSavedFilterDetail>();
            modelBuilder.Entity<PDPFilterTypeMaster>();
            // Home Page
            modelBuilder.Entity<HomePageTemplateMaster>();
            modelBuilder.Entity<HomePage>();
            modelBuilder.Entity<HomePageCTA>();
            modelBuilder.Entity<HomePageContentBlock>();
            //modelBuilder.Entity<HomePagePredefinedLinkMaster>();
            modelBuilder.Entity<HomePageTemplateCTAMaster>();
            modelBuilder.Entity<HomePageTemplateCTAMapping>();
            modelBuilder.Entity<HomePageTemplateContentBlockMaster>();
            modelBuilder.Entity<HomePageTemplateContentBlockMapping>();
            modelBuilder.Entity<HomePageFooter>();
            modelBuilder.Entity<HomePageFooterLink>();
            modelBuilder.Entity<FontWeightMaster>();
            modelBuilder.Entity<FontFamilyMaster>();
            modelBuilder.Entity<HomePagePredefinedActionMaster>();
            modelBuilder.Entity<RetailerSavedFilterDetail>()
               .HasOne(r => r.SavedFilter)
               .WithMany(r => r.FilterDetails)
               .HasForeignKey("SavedFilterId");
            modelBuilder.Entity<RetailerSavedFilterDetail>()
                .HasOne(r => r.PLPFilterType)
                .WithMany()
                .HasForeignKey("PLPFilterTypeId");
            modelBuilder.Entity<UserPasswordHistory>()
                .HasOne(p => p.UserInfo)
                .WithMany()
                .HasForeignKey(p => p.UserId);
            //UserRoleMaster - Status
            modelBuilder.Entity<UserRole>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            modelBuilder.Entity<User>()
                .HasOne(u => u.Preference)
                .WithOne(b => b.User)
                .HasForeignKey<UserPreference>(b => b.UserId);

            // USER - STATUS
            modelBuilder.Entity<User>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.StatusId);
            
            //   .HasForeignKey(u => u.RetailerID);
            // USER - STORE
            modelBuilder.Entity<User>()
                .HasOne(u => u.Store)
                .WithMany()
                .HasForeignKey("StoreId");
            // USER - USERTYPE
            modelBuilder.Entity<User>()
                .HasOne(u => u.UserType)
                .WithMany()
                .HasForeignKey(u => u.UserTypeId);
            // USER - USERROLEMASTER
            modelBuilder.Entity<User>()
               .HasOne(u => u.UserRole)
               .WithMany()
               .HasForeignKey(u => u.UserRoleId);

            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Retailer)
            //    .WithMany(u => u.Users)
            //    .HasForeignKey("RetailerID");
            modelBuilder.Entity<Retailer>()
                .HasOne(u => u.AccountDevelopmentManager)
                .WithMany()
                .HasForeignKey("AccountDevelopmentManagerId");
            modelBuilder.Entity<Retailer>()
                .HasOne(u => u.RetailerOrganization)
                .WithMany(u => u.Retailers)
                .HasForeignKey("RetailerOrganizationId");
            modelBuilder.Entity<RetailerUserMapping>()
               .HasOne(x => x.Retailer)
               .WithMany(y => y.RetaileUserMappings)
               .HasForeignKey(x => x.RetailerId);
            modelBuilder.Entity<RetailerUserMapping>()
                .HasOne(x => x.User)
                .WithMany(y => y.RetailerUserMappings)
                .HasForeignKey(x => x.UserId);
            // UrlToken
            modelBuilder.Entity<UrlToken>()
                .HasOne(u => u.User)
                .WithMany(u => u.UrlTokens)
                .HasForeignKey("UserId");
            modelBuilder.Entity<UrlToken>()
                .HasOne(u => u.Creator);
            modelBuilder.Entity<UrlToken>()
                .Property(u => u.CreatedDate)
                .HasDefaultValueSql("getdate()");
            //Menu
            modelBuilder.Entity<MenuItemMaster>().HasOne(ut => ut.Status).WithMany().HasForeignKey(ut => ut.StatusId);

            // Location - Retailer
            modelBuilder.Entity<Location>()
                .HasOne(l => l.Retailer)
                .WithMany()
                .HasForeignKey("RetailerId");

            // RetailerStoreDetail
            modelBuilder.Entity<RetailerStoreDetail>()
                .HasOne(u => u.Retailer)
                .WithMany(u => u.Stores)
                .HasForeignKey("RetailerId");

            modelBuilder.Entity<RetailerStatusChangeHistory>()
                .HasOne(u => u.Retailer)
                .WithMany(u => u.StatusChangeHistories)
                .HasForeignKey("RetailerId");
            
            modelBuilder.Entity<RequestStatusChangeHistory>()
                .HasOne(u => u.RequestInfo)
                .WithMany(u => u.StatusChangeHistories)
                .HasForeignKey("RequestId");

            modelBuilder.Entity<RetailerStageStatus>()
               .HasOne(u => u.Retailer)
               .WithMany(u => u.StageStatus)
               .HasForeignKey("RetailerId");

            // EmailTemplate
            modelBuilder.Entity<EmailTemplate>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.StatusId);

            // RequestInfo
            modelBuilder.Entity<RequestInfo>()
                .HasOne(u => u.RequestStatus)
                .WithMany()
                .HasForeignKey(u => u.RequestStatusID);
            modelBuilder.Entity<RequestInfo>()
                .HasOne(u => u.Retailer)
                .WithMany()
                .HasForeignKey(u => u.RetailerID);
            modelBuilder.Entity<RequestInfo>()
                .HasOne(u => u.RequestType)
                .WithMany()
                .HasForeignKey(u => u.RequestTypeID);

            modelBuilder.Entity<RequestInfo>()
                .HasOne(u => u.RequestType)
                .WithMany()
                .HasForeignKey(u => u.RequestTypeID);

            // EmailTypeMaster
            modelBuilder.Entity<EmailTypeMaster>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.StatusId);

            // EmailNotificationLog
            modelBuilder.Entity<EmailNotificationLog>()
                .HasOne(u => u.EmailTemplate)
                .WithMany()
                .HasForeignKey(u => u.EmailTemplateId);
            //modelBuilder.Entity<EmailNotificationLog>()
            //    .HasOne(u => u.EmailType)
            //    .WithMany()
            //    .HasForeignKey(u => u.EmailTypeId);

            // Resource - Status
            modelBuilder.Entity<Resource>()
                .HasOne(r => r.Status)
                .WithMany()
                .HasForeignKey("StatusId");

            // RequestStatusMaster
            // UserInfoStage - Status
            modelBuilder.Entity<UserInfoStage>()
                .HasOne(r => r.Status)
                .WithMany()
                .HasForeignKey("StatusId");

            // DocumentTypeMaster
            modelBuilder.Entity<DocumentTypeMaster>()
                .HasOne(r => r.Status)
                .WithMany()
                .HasForeignKey("StatusId");

            // RetailerStoreDocument
            modelBuilder.Entity<RetailerStoreDocument>()
                .HasOne(r => r.Retailer)
                .WithMany(r=>r.RetailerDocuments)
                .HasForeignKey("RetailerId");

            modelBuilder.Entity<RetailerStoreDocument>()
                .HasOne(r => r.Status)
                .WithMany()
                .HasForeignKey("StatusId");

            // RetailerStatusMaster
            modelBuilder.Entity<RetailerStatusMaster>()
                .HasOne(r => r.Status)
                .WithMany()
                .HasForeignKey("StatusId");


            //RetailerAddress - Status

            modelBuilder.Entity<User>()
              .HasOne(r => r.UserRole)
              .WithMany()
              .HasForeignKey(a => a.UserRoleId);
            modelBuilder.Entity<UserRole>().HasOne(s => s.Status).WithMany().HasForeignKey(s => s.StatusId);
            modelBuilder.Entity<UserRole>()
              .HasOne(r => r.Color)
              .WithMany()
              .HasForeignKey(a => a.ColorId);
            modelBuilder.Entity<UserRolePermissionCategory>()
                .HasOne(x => x.UserRole)
                .WithMany(y => y.UserRolePermissionCategories)
                .HasForeignKey(x => x.UserRoleId);
            modelBuilder.Entity<UserRolePermissionCategory>()
                .HasOne(x => x.PermissionCategory)
                .WithMany(y => y.UserRolePermissionCategories)
                .HasForeignKey(x => x.PermissionCategoryID);
            modelBuilder.Entity<UserRolePermissionCategoryMappedRole>()
                .HasOne(x => x.UserRole)
                .WithMany(y => y.UserRolePermissionCategoryMappedRoles)
                .HasForeignKey(x => x.UserRoleId);
            modelBuilder.Entity<UserRolePermissionCategoryMappedRole>()
                .HasOne(x => x.UserRolePermissionCategory)
                .WithMany(y => y.UserRolePermissionCategoryMappedRoles)
                .HasForeignKey(x => x.UserRolePermissionCategoryId);
            modelBuilder.Entity<PermissionMaster>()
               .HasOne(r => r.PermissionCategory)
               .WithMany(r =>r.Permissions)
               .HasForeignKey(a => a.PermissionCategoryId);
            modelBuilder.Entity<MenuItemPermission>()
              .HasOne(x => x.MenuItem)
              .WithMany(y => y.MenuItemPermissions)
              .HasForeignKey(x => x.MenuItemId);
            modelBuilder.Entity<MenuItemPermission>()
                .HasOne(x => x.Permission)
                .WithMany(y => y.MenuItemPermissions)
                .HasForeignKey(x => x.PermissionId);
            modelBuilder.Entity<RetailerAddress>()
               .HasOne(r => r.Status)
               .WithMany()
               .HasForeignKey(a => a.StatusId);
            // EntityType
            modelBuilder.Entity<EntityTypeMaster>();
            //AddressType - Status
            modelBuilder.Entity<AddressTypeMaster>()
               .HasOne(r => r.Status)
               .WithMany()
               .HasForeignKey(a => a.StatusId);
            //RetailerAddress - AddressType  
            modelBuilder.Entity<RetailerAddress>()
              .HasOne(r => r.AddressType)
              .WithMany()
              .HasForeignKey(a => a.AddressTypeId);
            //RetailerAddress - Retailer
            modelBuilder.Entity<RetailerAddress>()
                .HasOne(s => s.Retailer)
                .WithMany(r => r.Addresses)
                .HasForeignKey(s => s.RetailerId);
            //RetailerAddress - Province
            modelBuilder.Entity<RetailerAddress>()
              .HasOne(r => r.Province)
              .WithMany()
              .HasForeignKey(a => a.ProvinceId);
            //RetailerStoreDetail 
            modelBuilder.Entity<RetailerStoreDetail>();
            modelBuilder.Entity<OrderTotalRangeMaster>();

            //
            modelBuilder.Entity<RetailerStageStatus>()
                .HasOne(s => s.UserInfoStage)
                .WithMany(u => u.RetailerStageStatuses)
                .HasForeignKey(s => s.StageId);
            //Retailer - Entity
            modelBuilder.Entity<Retailer>()
                .HasOne(r => r.EntityType)
                .WithMany()
                .HasForeignKey(r => r.EntityTypeId);
            modelBuilder.Entity<RequestStatusChangeHistory>();

            // ItemCategoryMaster
            modelBuilder.Entity<ItemCategoryMaster>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);
            modelBuilder.Entity<ItemSubCategoryMaster>()
                .HasOne(i => i.Category)
                .WithMany(u => u.SubCategories)
                .HasForeignKey(i => i.CategoryId);
            modelBuilder.Entity<ItemSubSubCategoryMaster>()
               .HasOne(i => i.SubCategory)
               .WithMany(u => u.SubSubCategories)
               .HasForeignKey(i => i.SubCategoryId);
            // Item
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Category)
                .WithMany()
                .HasForeignKey(i => i.CategoryId);
            modelBuilder.Entity<Item>()
                .HasOne(i => i.SubCategory)
                .WithMany()
                .HasForeignKey(i => i.SubcategoryId);
            modelBuilder.Entity<Item>()
                .HasOne(i => i.SubSubCategory)
                .WithMany()
                .HasForeignKey(i => i.SubsubcategoryId);

            // ItemPlantTypeSpeciesMaster
            modelBuilder.Entity<ItemPlantTypeSpeciesMaster>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);

            // ItemSKUDetail
            modelBuilder.Entity<ItemSKUDetail>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusID);
            //modelBuilder.Entity<ItemSKUDetail>()
            //    .HasOne(i => i.Item)
            //    .WithMany(u => u.SkuDetails)
            //    .HasForeignKey(i => i.ItemNumber);
            modelBuilder.Entity<ItemSKUDetail>()
                .HasOne(i => i.Color)
                .WithMany()
                .HasForeignKey(i => i.colorId);
            // ItemImage
            modelBuilder.Entity<ItemImage>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);

            // ItemColorMaster
            modelBuilder.Entity<ItemColorMaster>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);

            // ProductTag
            modelBuilder.Entity<ProductTag>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);

            //modelBuilder.Entity<ProductTag>()
            //    .HasOne(i => i.ColorPalletMaster)
            //    .WithMany()
            //    .HasForeignKey(i => i.ColorId);

            // ProductTag
            modelBuilder.Entity<ProductTagItem>()
                .HasOne(i => i.Status)
                .WithMany()
                .HasForeignKey(i => i.StatusId);

            modelBuilder.Entity<ProductTagItem>()
                .HasOne(i => i.ProductTag)
                .WithMany()
                .HasForeignKey(i => i.ProductTagId);


            // ItemSKUDetailExtension
            modelBuilder.Entity<ItemSKUDetailExtension>().HasNoKey();
            // ProductTag - STATUS
            modelBuilder.Entity<ProductTag>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.StatusId);
            // ProductTag - Color
            modelBuilder.Entity<ProductTag>()
               .HasOne(u => u.Color)
               .WithMany()
               .HasForeignKey(u => u.ColorId);
            // ProductTagItem - Status
            //modelBuilder.Entity<ProductTagItem>()
            //   .HasOne(u => u.Status)
            //   .WithMany()
            //   .HasForeignKey(u => u.StatusId);
            // ProductTagItem - ProductTag
            modelBuilder.Entity<ProductTagItem>()
               .HasOne(u => u.ProductTag)
               .WithMany()
               .HasForeignKey(u => u.ProductTagId);
            //ProductTagItem - Item

            modelBuilder.Entity<ItemImage>();
            modelBuilder.Entity<ProductTagTypeMaster>()
                .HasOne(t => t.Status)
                .WithMany()
                .HasForeignKey(t => t.StatusId);
            modelBuilder.Entity<ProductTag>()
                .HasOne(t => t.TagType)
                .WithMany()
                .HasForeignKey(t => t.TagTypeId);
            modelBuilder.Entity<ProductTagCollection>()
                .HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<ProductTagCollectionMapping>()
                .HasOne(x => x.ProductTagCollection)
                .WithMany(y => y.ProductTagMappings)
                .HasForeignKey(x => x.CollectionId);
            modelBuilder.Entity<ProductTagCollectionMapping>()
                .HasOne(x => x.ProductTag)
                .WithMany(y => y.ProductTagMappings)
                .HasForeignKey(x => x.ProductTagId);
            modelBuilder.Entity<ItemAttribute>()
               .HasOne(t => t.Attribute)
               .WithMany()
               .HasForeignKey(t => t.AttributeId);
            modelBuilder.Entity<PDPItemAttributeMaster>()
               .HasOne(t => t.AttributeCategory)
               .WithMany()
               .HasForeignKey(t => t.PDPAttributeCategoryID);
            modelBuilder.Entity<OrderItemDetailTemp>()
               .HasOne(t => t.OrderDetailInfo)
               .WithMany()
               .HasForeignKey(t => t.OrderId);
            modelBuilder.Entity<OrderItemSKUDetailTemp>()
               .HasOne(t => t.OrderItemDetailInfo)
               .WithMany(a => a.OrderItemSkus)
               .HasForeignKey(t => t.OrderItemId);
            modelBuilder.Entity<OrderItemDetail>()
               .HasOne(t => t.OrderDetailInfo)
               .WithMany()
               .HasForeignKey(t => t.OrderId);
            modelBuilder.Entity<OrderItemSKUDetail>()
               .HasOne(t => t.OrderItemDetailInfo)
               .WithMany()
               .HasForeignKey(t => t.OrderItemId);
            modelBuilder.Entity<OrderStatusMaster>()
              .HasOne(t => t.MainOrderStatus)
              .WithMany()
              .HasForeignKey(t => t.MainOrderStatusID);
            modelBuilder.Entity<OrderDetail>()
               .HasOne(t => t.RetailerInfo)
               .WithMany()
               .HasForeignKey(t => t.RetailerID);
            modelBuilder.Entity<OrderDetail>()
               .HasOne(t => t.SubmittedUserInfo)
               .WithMany()
               .HasForeignKey(t => t.ModifiedBy);
            modelBuilder.Entity<OrderDetail>()
               .HasOne(t => t.OrderStatus)
               .WithMany()
               .HasForeignKey(t => t.OrderStatusId);

            modelBuilder.Entity<Banner>()
               .HasOne(t => t.BannerColour)
               .WithMany()
               .HasForeignKey(t => t.BannerColourId);
            modelBuilder.Entity<Banner>()
               .HasOne(t => t.Status)
               .WithMany()
               .HasForeignKey(t => t.StatusId);
            modelBuilder.Entity<Banner>()
               .HasOne(t => t.Author)
               .WithMany()
               .HasForeignKey(t => t.AuthorId);

            modelBuilder.Entity<CarouselBanner>()
               .HasOne(t => t.Status)
               .WithMany()
               .HasForeignKey(t => t.StatusId);
            modelBuilder.Entity<CarouselBanner>()
               .HasOne(t => t.Author)
               .WithMany()
               .HasForeignKey(t => t.AuthorId);

            modelBuilder.Entity<BannerColour>()
               .HasOne(t => t.Status)
               .WithMany()
               .HasForeignKey(t => t.StatusId);

            modelBuilder.Entity<BannerRetailerGroup>()
               .HasOne(t => t.Status)
               .WithMany()
               .HasForeignKey(t => t.StatusId);

            modelBuilder.Entity<BannerWebPage>()
               .HasOne(t => t.Status)
               .WithMany()
               .HasForeignKey(t => t.StatusId);

            modelBuilder.Entity<BannerStatusMaster>()
              .HasOne(t => t.Status)
              .WithMany()
              .HasForeignKey(t => t.StatusId);

            modelBuilder.Entity<RetailerGroup>()
                .HasOne(t => t.ColorPallet)
                .WithMany()
                .HasForeignKey(t => t.ColorID);


            modelBuilder.Entity<RetailerRetailerGroup>()
              .HasOne(t => t.Status)
              .WithMany()
              .HasForeignKey(t => t.StatusId);

            modelBuilder.Entity<RetailerRetailerGroup>()
               .HasOne(t => t.Retailer)
               .WithMany(t => t.RetailerGroups)
               .HasForeignKey(t => t.RetailerId);

            modelBuilder.Entity<OrderingDayConfig>()
              .HasOne(t => t.Status)
              .WithMany()
              .HasForeignKey(t => t.StatusId);
            modelBuilder.Entity<OrderingDayConfig>()
              .HasOne(t => t.Day)
              .WithMany()
              .HasForeignKey(t => t.DayId);

            modelBuilder.Entity<OrderingDayConfigRetailerGroupMapping>()
              .HasOne(t => t.Status)
              .WithMany()
              .HasForeignKey(t => t.StatusId);
            modelBuilder.Entity<OrderingDayConfigRetailerGroupMapping>()
              .HasOne(t => t.RetailerGroup)
              .WithMany()
              .HasForeignKey(t => t.RetailerGroupId);

            modelBuilder.Entity<ChangeHistory>()
              .HasOne(t => t.ActionType)
              .WithMany()
              .HasForeignKey(t => t.ChangeTypeId);

            modelBuilder.Entity<ChangeHistory>()
              .HasOne(t => t.LoggedByUser)
              .WithMany()
              .HasForeignKey(t => t.LoggedByUserId);

            ///////////////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity<DeliveryScheduleDocument>();
            modelBuilder.Entity<DeliveryScheduleTemp>()
                .HasOne(s => s.DeliveryScheduleDocument)
                .WithMany(r => r.DeliveryScheduleTemps)
                .HasForeignKey(s => s.DocumentId);
            modelBuilder.Entity<DeliverySchedule>();
            modelBuilder.Entity<DeliveryScheduleTemp>();
            modelBuilder.Entity<WebPage>();
            modelBuilder.Entity<ProductTagDataRule>();
            modelBuilder.Entity<ProductTagDataRuleAttribute>();
            modelBuilder.Entity<ProductTagDataRuleAttributeSign>();
            modelBuilder.Entity<ProductTagDataRuleAttributeType>();
            modelBuilder.Entity<ProductTagDataRuleLevel>();
            modelBuilder.Entity<ProductTagDataRuleSign>();
            modelBuilder.Entity<ItemSubSubCategoryMaster>();
            /////////////////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity<DivisorTypeMaster>();
            modelBuilder.Entity<SKUClassification>();
            modelBuilder.Entity<SKUClassificationProductMapping>();
            modelBuilder.Entity<NotificationMaster>();
            modelBuilder.Entity<UserNotificationMapping>();
            modelBuilder.Entity<UserPermissionCategoryMapping>();
            modelBuilder.Entity<RetailerUserPermissionCategoryMapping>();
            modelBuilder.Entity<UserStatusMaster>();
            /////////////////////////////////////////////////////////////////////////////////////
            
            modelBuilder.Entity<CustomerTransactionsD365>();
            modelBuilder.Entity<ExceptionLog>();
            modelBuilder.Entity<UserLoginHistory>();

            //modelBuilder.Entity<ChangeType>();
            modelBuilder.Entity<ActionTypeMaster>();
            modelBuilder.Entity<HomePage>();
            modelBuilder.Entity<HomePageRetailerGroupMaping>();
            modelBuilder.Entity<ContactTypeMaster>();
            modelBuilder.Entity<RetailerTypeMaster>();
            modelBuilder.Entity<RetailerOrganizationContactInfo>();

            modelBuilder.Entity<RelatedProductRuleDetail>();
            modelBuilder.Entity<RelatedProductRule>();
            modelBuilder.Entity<ProductRelationTypeMaster>();

            modelBuilder.Entity<RelatedProductDataRuleAttributeMaster>();
            modelBuilder.Entity<RelatedProductDataRuleAttributeSignMaster>();
            modelBuilder.Entity<RelatedProductDataRuleAttributeTypeMaster>();
            modelBuilder.Entity<RelatedProductDataRuleLevelMaster>();
            modelBuilder.Entity<RelatedProductDataRuleSignMaster>();
            modelBuilder.Entity<RelatedProduct>()
              .HasOne(t => t.RelatedProductRule)
              .WithMany()
              .HasForeignKey(t => t.RelatedProductRuleID);
            modelBuilder.Entity<ContentAlignmentMaster>();
            modelBuilder.Entity<ImageAlignmentMaster>();

        }
        public bool EnsureDeleted()
        {
            return this.Database.EnsureDeleted();
        }

        public override int SaveChanges()
        {
            IList<ChangeHistory> histories = null;
            if (_userId > 0)
            {
                var historyLogging = new HistoryLogging();
                histories = historyLogging.GetLogEntries(ChangeTracker, _userId).ToList();
            }

            var regularSavingRet = base.SaveChanges();

            if (histories != null && histories.Any())
            {
                ChangeHistories.AddRange(histories);
                base.SaveChanges();
            }

            return regularSavingRet;
        }
    }
}
