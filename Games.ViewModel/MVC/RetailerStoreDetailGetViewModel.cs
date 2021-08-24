using Games.DataModel;
using System;

namespace Games.ViewModel.MVC
{
    public class RetailerStoreDetailGetViewModel
    {
        public int ID { get; set; }
        public string StoreName { get; set; }
        public string RSANumber { get; set; }
        public string PrimaryContactFirstName { get; set; }
        public string PrimaryContactLastName { get; set; }
        public string PrimaryContactNumber { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string SecondaryContactFirstName { get; set; }
        public string SecondaryContactLastName { get; set; }
        public string SecondaryContactNumber { get; set; }
        public string SecondaryContactEmail { get; set; }
        public string PrimaryDeliveryContactFirstName { get; set; }
        public string PrimaryDeliveryContactLastName { get; set; }
        public string PrimaryDeliveryContactNumber { get; set; }
        public string SecondaryDeliveryContactFirstName { get; set; }
        public string SecondaryDeliveryContactLastName { get; set; }
        public string SecondaryDeliveryContactNumber { get; set; }
        public bool DeliveryConstraints { get; set; }
        public string DeliveryConstraintInformation { get; set; }
        public bool PalletDrop { get; set; }
        public ReceivingLocationMaster ReceivingLocation { get; set; }
        public DeliveryDoorAccessMaster DeliveryDoorAccess { get; set; }
        public int DeliveryDoorAccessID { get; set; }
        public int ReceivingLocationID { get; set; }
        public decimal DistanceFromDropToDoor { get; set; }
        public bool ExteriorSecuriryLighting { get; set; }
        public decimal StoreSize { get; set; }
        public decimal SecureStorageSize { get; set; }
        public decimal EstimatedFirstOrderSize { get; set; }
        public string AdditionalShiipingInfo { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ReceivingAreaPicUploadPath { get; set; }
        public string OCSStoreID { get; set; }
        public string CustomerGroup { get; set; }
        public string Language { get; set; }
        public string ChargesGroup { get; set; }
        public string Site { get; set; }
        public string Warehouse { get; set; }
        public string SalesPool { get; set; }
        public string Price { get; set; }
        public string TermsOfPayment { get; set; }
        public string MethodOfPayment { get; set; }
        //public string InvoiceAccount { get; set; }
        public string DeliveryTerms { get; set; }
        public string ModeOfDelivery { get; set; }
        public string SalesTaxGroup { get; set; }
        public string PriceIncludesSalesTax { get; set; }
        public string InvoicingAndDeliveryOnHold { get; set; }
    }
}
