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
    public class CreateConfigureHeroBannerViewModel : BaseAdminViewModel
    {
        public int Id { get; set; }

        //[Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        //[MaxLength(250)]
        public string BannerTitle { get; set; }

        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        [MaxLength(250)]
        public string BannerName { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
        public bool IsButtonVisible { get; set; }

        [JsonIgnore]
        [RestrictUploadDocument]
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public IFormFile IconFile { get; set; }

        public string IconFileName { get; set; }
        public string IconImageBase64String { get; set; }
        //[Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public string Description { get; set; }
        [Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public DateTime StartDateTime { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public DateTime PageLoadTime { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);

        [MustBeLaterThan("StartDateTime")]
        //[Required(ErrorMessageResourceName = "ThisFieldIsRequired", ErrorMessageResourceType = typeof(CommonResources))]
        public DateTime? EndDateTime { get; set; } = DateTime.ParseExact(DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public bool HasPublishBannerPermission { get; set; }
        public int TotalBanner { get; set; }
        public int BannerDisplayOrder { get; set; }
        public int LastBannerDisplayOrder { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
