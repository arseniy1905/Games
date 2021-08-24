using Games.Common.Resources;
using Games.DataModel;
using Games.ViewModel.Common;
using Games.ViewModel.Validation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class RetailerEditViewModel:BaseAdminViewModel
    {
        public RetailerEditViewModel()
        {
            OrderStatuses = new List<SelectListItem>();
            OrderTotalRanges = new List<SelectListItem>();
        }
        public int Id { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string RetailerName { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string PrimaryContactFirstName { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string PrimaryContactLastName { get; set; }
        public string SecondaryContactFirstName { get; set; }
        public string SecondaryContactLastName { get; set; }
        public string PrimaryContactNumber
        {
            get
            {
                return _PrimaryContactNumber;
            }
            set => _PrimaryContactNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _PrimaryContactNumber;
        public string PrimaryContactEmail { get; set; }
        public string SecondaryContactNumber
        {
            get
            {
                return _SecondaryContactNumber;
            }
            set => _SecondaryContactNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _SecondaryContactNumber;
        public string SecondaryContactEmail { get; set; }
        public string EntityName { get; set; }
        public IEnumerable<int> RetailerSelectedGroupIds { get; set; }
        public IEnumerable<RetailerGroupViewModel> RetailerGroupsWithAssigned { get; set; }
        public int AccountDevelopmentManagerId { get; set; }
        public List<SelectListItem> AccountDevelopmentManagers { get; set; }
        public List<RetailerAddressViewModel> RetailerAddresses { get; set; }
        public RetailerAddressViewModel StoreAddress { get; set; }
        public RetailerAddressViewModel CorporateAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }
        [RestrictUploadDocument]
        public IFormFile LogoUpload { get; set; }
        public string LogoImageOriginalFileName { get; set; }
        public string LogoImageFilePath { get; set; } = "/images/image-not-available.png";
        public int LogoImageMinSize { get; set; } = 200; //in px
        public int LogoImageMaxSize { get; set; } = 1000; //in px
        public int LogoImageFileMaxSize { get; set; } = 25; //in mb
        public RetailerStoreEditViewModel StoreDetail { get; set; }
        public List<SelectListItem> OrderStatuses { get; set; }
        public List<SelectListItem> OrderTotalRanges { get; set; }
        public bool HasDeleteRetailerPermission { get; set; }
        public bool HasEditRetailerPermission { get; set; }
        public bool HasViewRetailerUsersPermission { get; set; }
        public bool HasViewRetailerOrdersPermission { get; set; }
        public bool FlowThroughEnabled { get; set; }
        public List<SelectListItem> RetailerOrganizations { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public int RetailerOrganizationId { get; set; }
        public List<SelectListItem> RetailerTypes { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public int RetailerTypeId { get; set; }
    }

    public class RetailerStoreEditViewModel 
    {
        public RetailerStoreEditViewModel()
        {
            //Stages = new List<UserInfoStageViewModel>();
            ReceivingLocations = new List<Games.Common.Models.ReceivingLocationMaster>();
            OnboardProcessComments = new OnboardingProcessViewModel();
        }
        public int? Id { get; set; }
        public int? RetailerId { get; set; }

        public string PrimaryDeliveryContactFirstName { get; set; }
        public string PrimaryDeliveryContactLastName { get; set; }
        public string PrimaryDeliveryContactNumber { get; set; }
        public string SecondaryDeliveryContactFirstName { get; set; }
        public string SecondaryDeliveryContactLastName { get; set; }
        public string SecondaryDeliveryContactNumber { get; set; }
        public bool DeliveryConstraints { get; set; }
        public string DeliveryConstraintInformation { get; set; }
        public bool PalletDrop { get; set; }

        public IEnumerable<DeliveryDoorAccessMaster> DeliveryDoorAccessList { get; set; }

        public int DeliveryDoorAccessId { get; set; }
        public decimal DistancefromDroptoDoor { get; set; }
        public bool ExteriorSecurityLighting { get; set; }
        public int StoreSize { get; set; }
        public int SecureStorageSize { get; set; }
        public int EstimatedFirstOrderSize { get; set; }
        public string AdditionalShiipingInfo { get; set; }
        public IFormFile ReceivingAreaPictures { get; set; }
        public string ReceivingAreaPicOriginalFileName { get; set; }
        public string ReceivingAreaPicUploadPath { get; set; }

        public IEnumerable<Games.Common.Models.ReceivingLocationMaster> ReceivingLocations { get; set; }
        public int ReceivingLocationID { get; set; }
        public List<DayMasterViewModel> Days { get; set; }
        public string DayID { get; set; }
        public string Closing { get; set; }
        public string Opening { get; set; }
        public string StoreName { get; set; }
        public string RSANumber { get; set; }
        public int StoreId { get; set; }
        public string OCSStoreNumber { get; set; }
        public int RetailerStatusId { get; set; }
        public OnboardingProcessViewModel OnboardProcessComments { get; set; }


    }
}
