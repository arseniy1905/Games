using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class TaggedProductsViewModel
    {
        public TaggedProductsViewModel()
        {
            ProductList = new List<TaggedProductItemViewModel>();
            Paging = new PagingViewModel();
        }
        public List<TaggedProductItemViewModel> ProductList { get; set; }
        public string SearchWord { get; set; }
        public PagingViewModel Paging { get; set; }
        public bool IsSuccess { get; set; }
        public int ProductCategoryId { get; set; }
        public List<ItemCategoryListViewModel> ItemCategoryList { get; set; }

    }
}
