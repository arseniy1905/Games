using System;


namespace Games.DataModel
{
    public class OrderInvoice
    {
        public long Id { get; set; }
        public string CustomerAccount { get; set; }
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceDate { get; set; }
        public string Address { get; set; }
        public string PaymentDesc { get; set; }
        public string PaymMode { get; set; }
        public DateTime CreatedDate { get; set; }
    }
    public class OrderInvoiceCharge
    {
        public long Id { get; set; }
        public string CustomerAccount { get; set; }
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string InvoiceId { get; set; }
        public decimal ChargeAmount { get; set; }
        public string ChargeDescription { get; set; }   
        public decimal? ChargeGST { get; set; }
        public decimal? ChargeHST { get; set; }
        public decimal? ChargePST { get; set; }

    }
    public class OrderInvoiceDetail
    {
        public long Id { get; set; }
        public string CustomerAccount { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceDate { get; set; }
        public string Address { get; set; }
        public string ConfigId { get; set; }
        public string CurrencyCode { get; set; }
        public string CustomerName { get; set; }
        public string DlvDate { get; set; }
        public string InventColorId { get; set; }
        public string InventSizeId { get; set; }
        public string InventStyleId { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public decimal LineAmount { get; set; }
        public decimal LineAmountTax { get; set; }
        public string LineHeader { get; set; }
        public decimal LineNum { get; set; }
        public string McrDeliveryName { get; set; }
        public string McrDlvMode { get; set; }
        public string PaymentDesc { get; set; }
        public string PaymMode { get; set; }
        public decimal Qty { get; set; }
        public decimal SalesPrice { get; set; }
        public string SalesUnit { get; set; }
        public string SKU { get; set; }
        public decimal TaxAmount { get; set; }
        public string TaxGroup { get; set; }
        public string TaxItemGroup { get; set; }
        public DateTime CreatedDate { get; set; }
        public long OrderId { get; set; }
    }
}
