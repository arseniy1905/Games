using System;

namespace Games.Common.Models
{
    public class Requestheader
    {
        public string system { get; set; }
        public string transactiontype { get; set; }
        public string messagedatetime { get; set; }
        public string operation { get; set; }
        public string description { get; set; }
    }

    public class Createcustomerrequest
    {
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

    public class Requestdata
    {
        public Createcustomerrequest createcustomerrequest { get; set; }
    }

    public class Createcustomerd365request
    {
        public Requestheader requestheader { get; set; }
        public Requestdata requestdata { get; set; }
    }
    public class Createcustomerd365requestInfo
    {
        public Createcustomerd365request createcustomerd365request { get; set; }
    }

    public class Responsedata
    {
        public string message { get; set; }
        public string status { get; set; }
    }

    public class Responseheader
    {
        public string description { get; set; }
        public string identificationnumber { get; set; }
        public DateTime messagedatetime { get; set; }
        public string operation { get; set; }
        public string system { get; set; }
        public string transactiontype { get; set; }
        public string status { get; set; }
        public string statusdescription { get; set; }
    }

    public class Createcustomeracknowledgement
    {
        public Responsedata responsedata { get; set; }
        public Responseheader responseheader { get; set; }
    }

    public class CreatecustomeracknowledgementWraper
    {
        public Createcustomeracknowledgement createcustomeracknowledgement { get; set; }
    }
}
