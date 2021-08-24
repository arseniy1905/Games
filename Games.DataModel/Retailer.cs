
using Games.DataModel.DataAttribute;
using System;
using System.Collections.Generic;

namespace Games.DataModel
{
    public class Retailer
    {
        [NoMappingFrom("RetailerEditViewModel")]
        public int Id { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public int? RetailerOrganizationId { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public int? RetailerTypeId { get; set; }

        public RetailerOrganization RetailerOrganization { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public decimal? AccountBalance { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public string D365RetailerCode { get; set; }

        public string RetailerName { get; set; }
        public string StoreName { get; set; }
        public string RetailerNameFr { get; set; }
        public string CorporateName { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public bool? IsExistingD365Customer { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public string D365OnHoldStatus { get; set; }

        public IEnumerable<RetailerRetailerGroup> RetailerGroups { get; set; }
        public string CROLCertificateName { get; set; }
        public string CROLNumber { get; set; }
        public EntityTypeMaster EntityType { get; set; }
        public string PrimaryContactFirstName { get; set; }
        public string PrimaryContactLastName { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public string PrimaryContactNumber { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public string PrimaryContactEmail { get; set; }
        public string SecondaryContactFirstName { get; set; }
        public string SecondaryContactLastName { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public string SecondaryContactNumber { get; set; }

        public string SecondaryContactEmail { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public bool IsFirstNation { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public string FirstNationRegistrationNumber { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public string FirstNationBandNumber { get; set; }

        public RetailerStatusMaster RetailerStatus { get; set; }
        public bool? NDAAccepted { get; set; }
        public DateTime? NDAAcceptedDate { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public int? ApprovedByID { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public DateTime? ApprovedDate { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public int CreatedBy { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public DateTime CreatedDate { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public int ModifiedBy { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public DateTime ModifiedDate { get; set; }

        public List<RetailerAddress> Addresses { get; set; }
        public List<RetailerStoreDetail> Stores { get; set; }//need to remove
        public List<RetailerStageStatus> StageStatus { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public int RetailerStatusId { get; set; }

        //public List<User> Users { get; set; }
        [NoMappingFrom("RetailerEditViewModel")]
        public int? EntityTypeId { get; set; }

        [NoMappingFrom("RetailerEditViewModel")]
        public int? AllowedOrderDayId { get; set; }

        public ICollection<RetailerUserMapping> RetaileUserMappings { get; set; }
        public List<RetailerStatusChangeHistory> StatusChangeHistories { get; set; }
        public int? AccountDevelopmentManagerId { get; set; }
        public User AccountDevelopmentManager { get; set; }
        public List<RetailerStoreDocument> RetailerDocuments { get; set; }
        public int? RetailerGroupId { get; set; }
        public bool? FlowThroughEnabled { get; set; }
    }
}
