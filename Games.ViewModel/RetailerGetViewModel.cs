using Games.DataModel;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class RetailerGetViewModel
    {
        public int? Id { get; set; }
        public string D365RetailerCode { get; set; }
        public string RetailerId { get; set; }
        public string CROLCertificateName { get; set; }
        public string RetailerName { get; set; }
        public string OrganizationName { get; set; }
        public string CorporateName { get; set; }
        public int? RetailerGroupId { get; set; }
        public string CROLNumber { get; set; }
        public IEnumerable<RetailerGroupViewModel> RetailerGroups { get; set; }
        public EntityTypeMaster EntityType { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactNumber { get; set; }
        public string AccountManagerName { get; set; }
        public string AccountManagerNumber { get; set; }
        public bool IsFirstNation { get; set; }
        //public IEnumerable<LocationViewModel> Locations { get; set; }
        public RetailerStatusMaster RetailerStatus { get; set; }
        public string Action { get; set; }
        public string FirstNationRegistrationNumber { get; set; }
        public string FirstNationBandNumber { get; set; }
        public int? RetailerTypeId { get; set; }
    }
}
