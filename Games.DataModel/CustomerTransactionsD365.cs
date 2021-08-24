using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Games.DataModel
{
    public class CustomerTransactionsD365
    {
        public int ID { get; set; }
        public string CustomerAccount { get; set; }
        public decimal? AmountCUR { get; set; }
        public decimal? AmountMST { get; set; }
        public string DeliveryMode { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string DocumentNumber { get; set; }
        public string DueDate { get; set; }
        public string Interest { get; set; }
        public string Invoice { get; set; }
        public string PaymId { get; set; }
        public string PaymMethod { get; set; }
        public string PaymMode { get; set; }
        public string PaymReference { get; set; }
        public string PyamSchedId { get; set; }
        public string PaymSpec { get; set; }
        public string PaymTermId { get; set; }
        public string ReportingCurrencyAmount { get; set; }
        public string TransDate { get; set; }
        public string TXT { get; set; }
        public string Voucher { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
    }

}
