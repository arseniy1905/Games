using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class D365CustomerGroupMaster
    {
        public int Id { get; set; }
        public string CustomerGroup { get; set; }
        public string CustomerGroupFR { get; set; }
        public int StatusId { get; set; }

    }

    public class D365LanguageMaster
    {
        public int Id { get; set; }
        public string LanguageCode { get; set; }
        //public string CustomerGroupFR { get; set; }
        public int StatusId { get; set; }

    }
    public class D365ChargeGroupMaster
    {
        public int Id { get; set; }
        public string ChargeGroup { get; set; }
        public string ChargeGroupFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365SiteMaster
    {
        public int Id { get; set; }
        public string SiteName { get; set; }
        public string SiteNameFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365WarehouseMaster
    {
        public int Id { get; set; }
        public string Warehouse { get; set; }
        public string WarehouseFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365SalesPoolMaster
    {
        public int Id { get; set; }
        public string SalesPool { get; set; }
        public string SalesPoolFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365PriceMaster
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public string PriceFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365TermsOfPaymentMaster
    {
        public int Id { get; set; }
        public string TermsOfPayment { get; set; }
        public string TermsOfPaymentFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365MethodOfPaymentMaster
    {
        public int Id { get; set; }
        public string MethodOfPayment { get; set; }
        public string MethodOfPaymentFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365DeliveryTermsMaster
    {
        public int Id { get; set; }
        public string DeliveryTerms { get; set; }
        public string DeliveryTermsFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365ModeOfDeliveryMaster
    {
        public int Id { get; set; }
        public string ModeOfDelivery { get; set; }
        public string ModeOfDeliveryFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365SalesTaxGroupMaster
    {
        public int Id { get; set; }
        public string SalesTaxGroup { get; set; }
        public string SalesTaxGroupFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365PriceIncludesSalesTaxMaster
    {
        public int Id { get; set; }
        public string PriceIncludesSalesTax { get; set; }
        public string PriceIncludesSalesTaxFR { get; set; }
        public int StatusId { get; set; }
    }
    public class D365InvoicingAndDeliveryOnHoldMaster
    {
        public int Id { get; set; }
        public string InvoicingAndDeliveryOnHold { get; set; }
        public string InvoicingAndDeliveryOnHoldFR { get; set; }
        public int StatusId { get; set; }
    }
}
