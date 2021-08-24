using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class ProductTagCollectionsCategoryViewModel: BaseAdminViewModel
    {
        public ProductTagCollectionsCategoryViewModel()
        {
            CollectionCategoryList = new List<ProductTagCollectionCategoryListViewModel>();
            Paging = new PagingViewModel();
        }
        public List<ProductTagCollectionCategoryListViewModel> CollectionCategoryList { get; set; }
        public PagingViewModel Paging { get; set; }
        public bool HasUpdateCollectionCategoryPermission { get; set; }
        public bool HasCreateCollectionCategoryPermission { get; set; }
        public bool HasDeleteCollectionCategoryPermission { get; set; }
        public int Order { get; set; }
        public List<SelectListItem> OrderList { get; set; }
    }
}
