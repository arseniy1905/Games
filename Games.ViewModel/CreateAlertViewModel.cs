using Games.Common.Resources;
using Games.DataModel;
using Games.ViewModel.Validation;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class CreateAlertViewModel:BaseAdminViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(250)]
        public string BannerTitle { get; set; }

        [Range(1, 10000, ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public int BannerColourId { get; set; }
        public IEnumerable<BannerColour> BannerColours { get; set; }

        [JsonIgnore]
        [RestrictUploadDocument]
        public IFormFile IconFile { get; set; }
        public string IconFileName { get; set; }
        public string IconImageBase64String { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string Description { get; set; }
        public IEnumerable<int> RetailerGroupIds { get; set; }
        public IEnumerable<RetailerGroupViewModel> RetailerGroups { get; set; }

        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public IEnumerable<int> DisplayPageIds { get; set; }
        public IEnumerable<DisplayPageViewModel> DisplayPages { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public DateTime PageLoadTime { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);

        [MustBeLaterThan("StartDateTime")]
        public DateTime? EndDateTime { get; set; }
        public bool HasPublishBannerPermission { get; set; }
    }
}
