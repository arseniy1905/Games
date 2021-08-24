using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class ViewRelatedProductsViewModel
    {
        public ViewRelatedProductsViewModel()
        {
            Paging = new PagingViewModel();
            Paging.PageSize = 5;
            Paging.PageSizeList = new List<int> { 5,10, 20, 50, 100 };
            ProductList = new List<RelatedProductItemViewModel>();
        }
        public int ProductRelationTypeId { get; set; }
        public List<RelatedProductItemViewModel> ProductList { get; set; }
        public PagingViewModel Paging { get; set; }
        public bool IsRulesError { get; set; }
        public string RulesErrorMessage { get; set; }
    }
}
