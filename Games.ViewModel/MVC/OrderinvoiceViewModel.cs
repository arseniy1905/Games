using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrderInvoiceDocumentInfoViewModel
    {
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public List<string> InvoiceIds { get; set; }
    }

    public class OrderInvoiceViewModel
    {
        public OrderInvoiceViewModel()
        {
            Items = new List<OrderInvoiceItemDetailViewModel>();
            Charges = new List<OrderInvoiceChargeViewModel>();
        }
        public long OrderId { get; set; }
        public string SalesOrderNumberD365 { get; set; }
        public string InvoiceId { get; set; }
        public string OCSOrgName { get; set; }
        public string OCSOrgAddress { get; set; }
        public string OCSOrgCity { get; set; }
        public string OCSOrgProvince { get; set; }
        public string OCSOrgPostalCode { get; set; }
        public string CustomerAccountNo { get; set; }
        public string CustomerOrgname { get; set; }
        public AddressViewModel CustomerAddress { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string PaymentDesc  { get; set; }

        public List<OrderInvoiceItemDetailViewModel> Items { get; set; }
        public List<OrderInvoiceChargeViewModel> Charges { get; set; }
    }

    public class OrderInvoiceItemDetailViewModel
    {
        public string CustomerName { get; set; }
        public string SKU { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public string SaleUnit { get; set; }
        public decimal Ammount { get; set; }
        public decimal Tax { get; set; }

    }
    public class OrderInvoiceChargeViewModel {
        public string Description { get; set; }
        public decimal Ammount { get; set; }
        public decimal Tax { get; set; }
    }

}
