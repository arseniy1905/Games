using Games.Common.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class PrizeViewModel
    {
        public int Id { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "DescriptionLine1")]
        [Required(ErrorMessageResourceName = "EnterValidDescription", ErrorMessageResourceType = typeof(CommonResources))]
        [StringLength(50, ErrorMessageResourceName = "EnterValidDescription", ErrorMessageResourceType = typeof(CommonResources))]
        public string DescriptionLine1 { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "DescriptionLine2")]
        [Required(ErrorMessageResourceName = "EnterValidDescription", ErrorMessageResourceType = typeof(CommonResources))]
        [StringLength(150, ErrorMessageResourceName = "EnterValidDescription", ErrorMessageResourceType = typeof(CommonResources))]
        public string DescriptionLine2 { get; set; }
        public string ImagePath { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Price")]
        [Required(ErrorMessageResourceName = "EnterValidPrice", ErrorMessageResourceType = typeof(CommonResources))]
        [Range(1, 1000000, ErrorMessageResourceName = "EnterValidPrice", ErrorMessageResourceType = typeof(CommonResources))]
        public decimal? Price { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Stars")]
        [Required(ErrorMessageResourceName = "EnterValidStarsNumber", ErrorMessageResourceType = typeof(CommonResources))]
        [Range(1, 5, ErrorMessageResourceName = "EnterValidStarsNumber", ErrorMessageResourceType = typeof(CommonResources))]
        public int Stars { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Status")]
        [Required(ErrorMessageResourceName = "EnterValidStatus", ErrorMessageResourceType = typeof(CommonResources))]
        [Range(1, int.MaxValue, ErrorMessageResourceName = "EnterValidStatus", ErrorMessageResourceType = typeof(CommonResources))]
        public int StatusId { get; set; }
        [Display(ResourceType = typeof(CommonResources), Name = "Status")]
        public string StatusText { get; set; }
        public List<SelectListItem> Statuses { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Quarter { get; set; }
    }
}
