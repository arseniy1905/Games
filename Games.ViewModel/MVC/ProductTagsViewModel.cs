using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class ProductTagsViewModel:BaseAdminViewModel
    {
        public ProductTagsViewModel()
        {
            Tabs = new List<TabViewModel>();
            TaggedProducts = new TaggedProductsViewModel();
            TagGeneral = new ProductTagGeneralViewModel();
            SelectedProductIds = string.Empty;
            IdSeparator = string.Empty;

        }
        public List<TabViewModel> Tabs { get; set; }
        public TaggedProductsViewModel TaggedProducts { get; set; }
        public ProductTagGeneralViewModel TagGeneral { get; set; }
        public int Id { get; set; }
        public string SelectedProductIds { get; set; }
        public string IdSeparator { get; set; }
        public bool? IsSaved { get; set; }
        public bool HasDeleteTagPermission { get; set; }
        public bool HasEditTagPermission { get; set; }
        public bool HasCreateTagPermission { get; set; }
        public TagDataRulesViewModel Rules { get; set; }
        public string DataRulesResultJson { get; set; }
    }
}
