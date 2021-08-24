using Games.Common.Resources;
using Games.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class RetailerViewModel
    {
        public RetailerViewModel()
        {
            Addresses = new List<RetailerAddress>();
        }
        public int? Id { get; set; }
        public string D365RetailerCode { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string LogoImagePath { get; set; }
        public string RetailerName { get; set; }
        public IEnumerable<RetailerGroupViewModel> RetailerGroups { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string PrimaryContactName { get; set; }
        public string PrimaryContactNumber { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string AccountManagerName { get; set; }
        public string AccountManagerNumber { get; set; }
        public IEnumerable<LocationViewModel> Locations { get; set; }
        public RetailerStatusMaster RetailerStatus { get; set; }
        public string Action { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedByID { get; set; }
        public string FirstNationBandNumber { get; set; }
        public string FirstNationRegistrationNumber { get; set; }
        public bool? NDAAccepted { get; set; }
        public List<RetailerStoreDetailsViewModel> Stores { get; set; }
        public DateTime? NDAAcceptedDate { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public IEnumerable<RetailerAddress> Addresses { get; set; }
        public string CROLNumber { get; set; } //CRSANumber in view
        public string RetailerGroupNames { get; set; }
        public bool IsVisible { get; set; }
    }
}
