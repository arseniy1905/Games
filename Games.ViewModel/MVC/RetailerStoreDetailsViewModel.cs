using Games.DataModel;
using Games.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Games.ViewModel.MVC
{
    public class RetailerStoreDetailsViewModel : RetailerinfoAbstractViewModel
    {
        public RetailerStoreDetailsViewModel()
        {
            //Stages = new List<UserInfoStageViewModel>();
            ReceivingLocations = new List<Games.Common.Models.ReceivingLocationMaster>();
            OnboardProcessComments = new OnboardingProcessViewModel();
        }
        public int? Id { get; set; }
        public int? RetailerId { get; set; }

        //public List<UserInfoStageViewModel> Stages { get; set; }
        [Required]
        [MaxLength(100)]
        public string PrimaryDeliveryContactFirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string PrimaryDeliveryContactLastName { get; set; }

        [MaxLength(10), Required(ErrorMessage = "Primary Contact Number required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Primary Contact Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Primary Contact Number")]
        public string PrimaryDeliveryContactNumber
        {
            get
            {
                return _PrimaryDeliveryContactNumber;
            }
            set => _PrimaryDeliveryContactNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _PrimaryDeliveryContactNumber;

        [MaxLength(100), Required]
        public string SecondaryDeliveryContactFirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string SecondaryDeliveryContactLastName { get; set; }
        [MaxLength(10), Required(ErrorMessage = "Secondary Contact Number required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Secondary Contact Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Secondary Contact Number")]
        public string SecondaryDeliveryContactNumber
        {
            get
            {
                return _SecondaryDeliveryContactNumber;
            }
            set => _SecondaryDeliveryContactNumber = string.Join("", (value + "").Where(x => Char.IsDigit(x)).Take(10));
        }
        private string _SecondaryDeliveryContactNumber;

        [Required]
        public bool DeliveryConstraints { get; set; }
        [Required]
        [MaxLength(2000)]
        public string DeliveryConstraintInformation { get; set; }
        [Required]
        public bool PalletDrop { get; set; }

        public IEnumerable<DeliveryDoorAccessMaster> DeliveryDoorAccessList { get; set; }

        public int DeliveryDoorAccessId { get; set; }
        [Range(1, 999999)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal DistancefromDroptoDoor { get; set; }
        [Required]
        public bool ExteriorSecurityLighting { get; set; }
        [Range(1, 999999)]
        [Required]
        public int StoreSize { get; set; }
        [Range(1, 999999)]
        [Required]
        public int SecureStorageSize { get; set; }
        [Range(1, 999999)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10, 2)")]
        public int EstimatedFirstOrderSize { get; set; }
        [MaxLength(2000)]
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
