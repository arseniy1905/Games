using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class ConfigureHeroBannersViewModel: BaseAdminViewModel
    {
        public ConfigureHeroBannersViewModel()
        {
            AlertList = new List<ConfigureHeroBannerListViewModel>();
            Paging = new PagingViewModel();
        }
        public List<ConfigureHeroBannerListViewModel> AlertList { get; set; }
        public PagingViewModel Paging { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool HasUpdateBannerPermission { get; set; }
        public bool HasCreateBannerPermission { get; set; }
        public bool HasDeleteBannerPermission { get; set; }
        public bool HasPublishBannerPermission { get; set; }
    }
}
