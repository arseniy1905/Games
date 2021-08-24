using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class ProductsViewModel:BaseAdminViewModel
    {
        public ProductsViewModel()
        {
            ProductList = new List<ProductViewModel>();
            Paging = new PagingViewModel();
        }

        public List<ProductViewModel> ProductList { get; set; }
        public PagingViewModel Paging { get; set; }
        public int ItemCategoryId { get; set; }
        public List<ItemCategoryListViewModel> ItemCategoryMasters { get; set; }
    }
}
