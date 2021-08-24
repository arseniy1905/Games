using Games.Common.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class InviteRetailerViewModel:BaseAdminViewModel
    {
        [Required, MaxLength(255)]
        //[RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$",
        // ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){1,})+)$", ErrorMessageResourceName = "EnterValidEmail", ErrorMessageResourceType = typeof(CommonResources))]
        public string Email { get; set; }

        [Required, MaxLength(50)]
        public string CROLNumber { get; set; }

        [Required, MaxLength(255)]
        public string Subject { get; set; }

        [Required]
        public string Body { get; set; }
        [Required, MaxLength(50)]
        public string CustomerID { get; set; }
        public int CustomerType { get; set; }

        public IFormFile AttachmentFile { get; set; }
        public string InviteURL { get; set; }
        public int RequestID { get; set; }
        public int ErrorID { get; set; }
        public string ErrorDescription { get; set; }

        public string D365RetailerCode { get; set; }
        public string RSANumber { get; set; }
        public string City { get; set; }
        public int ProvinceId { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string PostalCode { get; set; }
        public string ChargesGroup { get; set; }
        public string CustomerGroup { get; set; }
        public string ModeOfDelivery { get; set; }
        public string DeliveryTerms { get; set; }
        public string Price { get; set; }
        public string Language { get; set; }
        public string StoreName { get; set; }
        public string RetailerName { get; set; }
        public string PrimaryContactNumber { get; set; }
        public string CROLCertificateName { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string MethodOfPayment { get; set; }
        public string TermsOfPayment { get; set; }
        public string SalesPool { get; set; }
        public string SalesTaxGroup { get; set; }
        public string Site { get; set; }
        public string OCSStoreID { get; set; }
        public string Warehouse { get; set; }
        public string InvoicingAndDeliveryOnHold { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public int RetailerOrganizationId { get; set; }
        public List<SelectListItem> RetailerOrganizations { get; set; }
    }

    public class D365ReadExistingCustomerInfoViewModel
    {
        public int ErrorID { get; set; }
        public string ErrorDescription { get; set; }
        public string D365RetailerCode { get; set; }
        public string RSANumber { get; set; }
        public string CROLNumber { get; set; }
        public string City { get; set; }
        public int ProvinceId { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string PostalCode { get; set; }
        public string ChargesGroup { get; set; }
        public string CustomerGroup { get; set; }
        public string ModeOfDelivery { get; set; }
        public string DeliveryTerms { get; set; }
        public string Price { get; set; }
        public string Language { get; set; }
        public string StoreName { get; set; }
        public string RetailerName { get; set; }
        public string PrimaryContactNumber { get; set; }
        public string CROLCertificateName { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string MethodOfPayment { get; set; }
        public string TermsOfPayment { get; set; }
        public string SalesPool { get; set; }
        public string SalesTaxGroup { get; set; }
        public string Site { get; set; }
        public string OCSStoreID { get; set; }
        public string Warehouse { get; set; }
        public string InvoicingAndDeliveryOnHold { get; set; }

    }

}
