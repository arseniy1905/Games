using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class ProductTagCollectionsViewModel:BaseAdminViewModel
    {
        public ProductTagCollectionsViewModel()
        {
            CollectionList = new List<ProductTagCollectionListViewModel>();
            Paging = new PagingViewModel();
        }
        public List<ProductTagCollectionListViewModel> CollectionList { get; set; }
        public PagingViewModel Paging { get; set; }
        public bool HasUpdateCollectionPermission { get; set; }
        public bool HasCreateCollectionPermission { get; set; }
        public bool HasDeleteCollectionPermission { get; set; }
        public int Category { get; set; }
        public List<ProductTagCollectionCategoryViewModel> ItemCategoryListViewModels { get; set; }

    }
}
