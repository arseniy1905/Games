namespace Games.Common.Models
{
    public class Searchcustomerd365requestInfo
    {
        public SearchCustomerd365Request searchcustomerd365request { get; set; }
    }
    public class SearchCustomerd365Request
    {
        public Requestheader requestheader { get; set; }
        public SearchCustomerRequestData requestdata { get; set; }
    }

    public class SearchCustomerRequestData
    {
        public string customeraccount { get; set; }
    }

    public class Searchcustomerd365ResponseInfo
    {
        public SearchCustomerd365Response searchcustomerd365response { get; set; }
    }
    public class SearchCustomerd365Response
    {
        public Responseheader responseheader { get; set; }
        public SearchCustomerd365ResponseData responsedata { get; set; }
    }
    public class SearchCustomerd365ResponseData
    {
        public SearchCustomerResponse customerresponse { get; set; }
    }

    public class SearchCustomerResponse
    {
        public string customeraccount { get; set; }
        public string organizationnumber { get; set; }
        public string identificationnumber { get; set; }
        public string addresscity { get; set; }
        public string addresscountryregionid { get; set; }
        public string addresscountryregionisocode { get; set; }
        public string addressdescription { get; set; }
        public string addresslocationroles { get; set; }
        public string addressstate { get; set; }
        public string addressstreet { get; set; }
        public string addressstreetnumber { get; set; }
        public string addresszipcode { get; set; }
        public string chargesgroupid { get; set; }
        public string customergroupid { get; set; }
        public string deliverymode { get; set; }
        public string deliveryterms { get; set; }
        public string discountpricegroupid { get; set; }
        public string languageid { get; set; }
        public string namealias { get; set; }
        public string onholdstatus { get; set; }
        public string organizationname { get; set; }
        public string paymentmethod { get; set; }
        public string paymentterms { get; set; }
        public string primarycontactemail { get; set; }
        public string primarycontactemaildescription { get; set; }
        public string primarycontactemailpurpose { get; set; }
        public string primarycontactphone { get; set; }
        public string primarycontactphonepurpose { get; set; }
        public string salescurrencycode { get; set; }
        public string salesorderpoolid { get; set; }
        public string salestaxgroup { get; set; }
        public string siteid { get; set; }
        public string storeid { get; set; }
        public string warehouseid { get; set; }
    }
}
