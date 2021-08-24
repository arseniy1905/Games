using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class SKUClassificationViewModel:BaseAdminViewModel
    {
        public SKUClassificationViewModel()
        {
            HasCreatePermission = true;
            HasEditPermission = true;
            HasEditPermission = true;
            GeneralInfo = new SKUClassificationGeneral();
            ProductList = new List<SKUClassificationProductViewModel>();
            Paging = new PagingViewModel();
            ExistingSKUs = string.Empty;
        }
        public int Id { get; set; }
        public string SKU { get; set; }
        public bool HasCreatePermission { get; set; }
        public bool HasEditPermission { get; set; }
        public SKUClassificationGeneral GeneralInfo { get; set; }
        public string IdSeparator { get; set; }
        public string SelectedProductIds { get; set; }
        public bool HasUploadPermission { get; set; }
        public List<TabViewModel> Tabs { get; set; }
        public List<SKUClassificationProductViewModel> ProductList { get; set; }
        public PagingViewModel Paging { get; set; }
        public int ItemCategoryId { get; set; }
        public List<ItemCategoryListViewModel> ItemCategoryMasters { get; set; }
        public string ExistingSKUs { get; set; }
    }
}
