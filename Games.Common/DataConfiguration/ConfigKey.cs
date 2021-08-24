namespace Games.Common.DataConfiguration
{
    public class ConfigKey
    {
        protected ConfigKey()
        {

        }
        private static readonly ConfigKey _accessFailedCountLimit = new ConfigKey() { Key = nameof(ACCESS_FAILED_COUNT_LIMIT) };
        private static readonly ConfigKey _siteURL = new ConfigKey() { Key = nameof(SITE_URL) };
        private static readonly ConfigKey _contactUsURL = new ConfigKey() { Key = nameof(CONTACTUS_URL) };
        private static readonly ConfigKey _faqURL = new ConfigKey() { Key = nameof(FAQ_URL) };
        private static readonly ConfigKey _baseURL = new ConfigKey() { Key = nameof(BASE_URL) };
        private static readonly ConfigKey _inviteURL = new ConfigKey() { Key = nameof(INVITE_URL) };
        private static readonly ConfigKey _inviteUrlExpireDays = new ConfigKey() { Key = nameof(INVITE_URL_EXPIRE_DAYS) };
        private static readonly ConfigKey _createCustomerAPIURL = new ConfigKey() { Key = nameof(CREATE_CUSTOMER_API_URL) };
        private static readonly ConfigKey _createCustomerAPIKeyName = new ConfigKey() { Key = nameof(CREATE_CUSTOMER_API_KEY_NAME) };
        private static readonly ConfigKey _createCustomerAPIKeyValue = new ConfigKey() { Key = nameof(CREATE_CUSTOMER_API_KEY_VALUE) };
        private static readonly ConfigKey _searchCustomerAPIURL = new ConfigKey() { Key = nameof(SEARCH_CUSTOMER_API_URL) };
        private static readonly ConfigKey _searchCustomerAPIKeyName = new ConfigKey() { Key = nameof(SEARCH_CUSTOMER_API_KEY_NAME) };
        private static readonly ConfigKey _searchCustomerAPIKeyValue = new ConfigKey() { Key = nameof(SEARCH_CUSTOMER_API_KEY_VALUE) };
        private static readonly ConfigKey _lastCatalogueUpdateTimeStamp = new ConfigKey() { Key = nameof(LAST_CATALOGUE_UPDATE) };
        private static readonly ConfigKey _HomeRetailerSupport = new ConfigKey() { Key = nameof(HOMERETAILERSUPPORT) };
        private static readonly ConfigKey _HomePromotions = new ConfigKey() { Key = nameof(HOMEPROMOTIONS) };
        private static readonly ConfigKey _HomeArticles = new ConfigKey() { Key = nameof(HOMEARTICLES) };
        private static readonly ConfigKey _HomeContentCall = new ConfigKey() { Key = nameof(HOMECONTENTCALL) };
        private static readonly ConfigKey _HomeContact = new ConfigKey() { Key = nameof(HOMECONTACT) };
        private static readonly ConfigKey _HomeProductPreview = new ConfigKey() { Key = nameof(HOMEPRODUCTPREVIEW) };
        private static readonly ConfigKey _HomeResources = new ConfigKey() { Key = nameof(HOMERESOURCES) };
        private static readonly ConfigKey _HomeFaq = new ConfigKey() { Key = nameof(HOMEFAQ) };
        private static readonly ConfigKey _GoogleTagManagerVersion = new ConfigKey() { Key = nameof(GOOGLE_TAG_MANAGER_VERSION) };


        public static ConfigKey ACCESS_FAILED_COUNT_LIMIT => _accessFailedCountLimit;
        public static ConfigKey SITE_URL => _siteURL;
        public static ConfigKey BASE_URL => _baseURL;
        public static ConfigKey CONTACTUS_URL => _contactUsURL;
        public static ConfigKey FAQ_URL => _faqURL;
        public static ConfigKey INVITE_URL => _inviteURL;
        public static ConfigKey INVITE_URL_EXPIRE_DAYS => _inviteUrlExpireDays;
        public static ConfigKey CREATE_CUSTOMER_API_URL => _createCustomerAPIURL;
        public static ConfigKey CREATE_CUSTOMER_API_KEY_NAME => _createCustomerAPIKeyName;
        public static ConfigKey CREATE_CUSTOMER_API_KEY_VALUE => _createCustomerAPIKeyValue;
        public static ConfigKey SEARCH_CUSTOMER_API_URL => _searchCustomerAPIURL;
        public static ConfigKey SEARCH_CUSTOMER_API_KEY_NAME => _searchCustomerAPIKeyName;
        public static ConfigKey SEARCH_CUSTOMER_API_KEY_VALUE => _searchCustomerAPIKeyValue;
        public static ConfigKey LAST_CATALOGUE_UPDATE => _lastCatalogueUpdateTimeStamp;
        public static ConfigKey HOMERETAILERSUPPORT => _HomeRetailerSupport;
        public static ConfigKey HOMEPROMOTIONS => _HomePromotions;
        public static ConfigKey HOMEARTICLES => _HomeArticles;
        public static ConfigKey HOMECONTENTCALL => _HomeContentCall;
        public static ConfigKey HOMECONTACT => _HomeContact;
        public static ConfigKey HOMEPRODUCTPREVIEW => _HomeProductPreview;
        public static ConfigKey HOMERESOURCES => _HomeResources;
        public static ConfigKey HOMEFAQ => _HomeFaq;
        public static ConfigKey GOOGLE_TAG_MANAGER_VERSION => _GoogleTagManagerVersion;
        public string Key { get; protected set; }
    }
}
