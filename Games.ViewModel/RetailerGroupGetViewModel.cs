using Games.ViewModel.Common;
using System;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class RetailerGroupGetViewModel:BaseAdminViewModel
    {
        public RetailerGroupGetViewModel()
        {
            RetailerGroupList = new List<RetailerGroupListViewModel>();
            Paging = new PagingViewModel();
        }
        public List<RetailerGroupListViewModel> RetailerGroupList { get; set; }
        public PagingViewModel Paging { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<RetailerRetailerGroupViewModel> retailerRetailerGroup { get; set; }
        public bool HasUpdateRetailerGroupPermission { get; set; }
        public bool HasCreateRetailerGroupPermission { get; set; }
        public bool HasDeleteRetailerGroupPermission { get; set; }
    }

}
