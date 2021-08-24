using Games.ViewModel.Common;
using System;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class AlertBannersViewModel:BaseAdminViewModel
    {
        public AlertBannersViewModel()
        {
            AlertList = new List<AlertBannerListViewModel>();
            Paging = new PagingViewModel();
        }
        public List<AlertBannerListViewModel> AlertList { get; set; }
        public PagingViewModel Paging { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool HasUpdateBannerPermission { get; set; }
        public bool HasCreateBannerPermission { get; set; }
        public bool HasDeleteBannerPermission { get; set; }
        public bool HasPublishBannerPermission { get; set; }
    }

}
