using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class RequestDetailViewModel:BaseAdminViewModel
    {
        public int RequestId { get; set; }
        public RequestDetailViewModel()
        {
            ConfirmViewModal = new ConfirmViewModal();
        }
        public RetailerGetViewModel retailerViewModel { get; set; }
        public RetailerStoreDetailGetViewModel retailerStoreDetailGetViewModel { get; set; }
        public IEnumerable<RetailerStoreHoursViewModel> retailerStoreHoursViewModel { get; set; }
        public IEnumerable<RetailerStoreDocumentViewModel> retailerStoreDocumentViewModel { get; set; }
        public List<RetailerAddressViewModel> retailerAddressViewModel { get; set; }
        public RequestInfoViewModel requestInfoViewModel { get; set; }
        //public List<Request>
        public ConfirmViewModal ConfirmViewModal { get; set; }
        public string JavascriptToRun { get; set; }
        [Required(ErrorMessage = "Store ID is required.")]
        [MaxLength(4)]
        public string OCSStoreID { get; set; }
        [Required(ErrorMessage = "Customer Group is required.")]
        [MaxLength(50)]
        public string CustomerGroup { get; set; }
        [Required(ErrorMessage = "Language is required.")]
        [MaxLength(10)]
        public string Language { get; set; }
        [Required(ErrorMessage = "Charge Group is required.")]
        [MaxLength(30)]
        public string ChargesGroup { get; set; }
        [Required(ErrorMessage = "Site is required.")]
        [MaxLength(30)]
        public string Site { get; set; }
        [Required(ErrorMessage = "Warehouse is required.")]
        [MaxLength(30)]
        public string Warehouse { get; set; }
        [Required(ErrorMessage = "Sales Pool is required.")]
        [MaxLength(30)]
        public string SalesPool { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [MaxLength(20)]
        public string Price { get; set; }
        [Required(ErrorMessage = "Terms of payment is required.")]
        [MaxLength(30)]
        public string TermsOfPayment { get; set; }
        [Required(ErrorMessage = "Method of payment is required.")]
        [MaxLength(30)]
        public string MethodOfPayment { get; set; }
        [Required(ErrorMessage = "Invoice Account is required.")]
        [MaxLength(30)]
        //public string InvoiceAccount { get; set; }
        //[Required(ErrorMessage = "Delivery Terms is required.")]
        //[MaxLength(30)]
        public string DeliveryTerms { get; set; }
        [Required(ErrorMessage = "Mode of Delivery is required.")]
        [MaxLength(30)]
        public string ModeOfDelivery { get; set; }
        [Required(ErrorMessage = "Sales Tax Group is required.")]
        [MaxLength(30)]
        public string SalesTaxGroup { get; set; }
        [Required(ErrorMessage = "Price Includes Sales Tax is required.")]
        [MaxLength(30)]
        public string PriceIncludesSalesTax { get; set; }
        [Required(ErrorMessage = "Invoice and Delivery On Hold is required.")]
        [MaxLength(30)]
        public string InvoicingAndDeliveryOnHold { get; set; }
        public bool HasFirstPassApprovalPermission { get; set; }
        public bool HasCreateCustomerPermission { get; set; }
        public int RetailerTypeId { get; set; }
        public List<SelectListItem> RetailerTypes { get; set; }
    }
}
