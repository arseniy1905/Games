using Games.Common.Resources;
using Games.ViewModel.Validation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Games.ViewModel.MVC
{
    public class CreateEmailBlastViewModel : BaseAdminViewModel
    {
        public CreateEmailBlastViewModel()
        {
            Retailers = new List<RetailerRetailerGroupViewModel>();
            RetailerGroups = new List<RetailerGroupViewModel>();
        }

        public int Id { get; set; }
        public int RecipientTypeId {get;set;}
        public string CustomerId { get; set; }
        public string CROL { get; set; }
        public string EmailAddress { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string EmailSubject { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string EmailBody { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public IEnumerable<int> RetailerIds { get; set; }
        public List<RetailerRetailerGroupViewModel> Retailers { get; set; }
        public IEnumerable<int> RetailerGroupIds { get; set; }
        public IEnumerable<RetailerGroupViewModel> RetailerGroups { get; set; }
        [JsonIgnore]
        [RestrictUploadDocument]
        public IFormFile IconFile { get; set; }
        public string IconFileName { get; set; }
        public string IconImageBase64String { get; set; }
        public List<string> ToAddress { get; set; }
        public bool IsRetailer { get; set; }
    }


}
