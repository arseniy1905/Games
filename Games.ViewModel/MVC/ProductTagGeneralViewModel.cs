using Games.Common.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class ProductTagGeneralViewModel
    {
        public ProductTagGeneralViewModel()
        {
            Colors = new List<Games.Common.Models.ColorPalletMaster>();
            IsSalesFlow = true;
            IsTagSearchable = true;
            DataRuleList = new List<TagDataRuleViewModel>();
            TagNumbers = new List<SelectListItem>();
        }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "EnterTagName")]
        public string NameOfTag { get; set; }
        public bool IsTagSearchable { get; set; }
        public bool IsSalesFlow { get; set; }
        [Required(ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "ColorRequired")]
        [Range(1, 10000, ErrorMessageResourceType = typeof(CommonResources), ErrorMessageResourceName = "ColorRequired")]
        public int ColorId { get; set; }
        public List<Games.Common.Models.ColorPalletMaster> Colors;

        public int TagTypeId { get; set; }
        public bool IsDataDriven { get; set; }
        public List<TagDataRuleViewModel> DataRuleList { get; set; }
        public int TagNumber { get; set; }
        public List<SelectListItem> TagNumbers { get; set; }

    }
}
