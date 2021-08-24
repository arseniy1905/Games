using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class RetailerListViewModel:BaseAdminViewModel
    {
        public RetailerListViewModel()
        {
            Paging = new PagingViewModel();
            RetailerOrganizations = new List<RetailerOrganizationViewModel>();
        }
        public IEnumerable<RetailerViewModel> Retailers { get; set; }
        public IEnumerable<SelectListItem> RetailerStatusList { get; set; }
        public IEnumerable<SelectListItem> RetailerStoreList { get; set; }
        public List<RetailerOrganizationViewModel> RetailerOrganizations { get; set; }
        public string SearchWord { get; set; }
        public int SelectedLocked { get; set; }
        public int SelectedStatus { get; set; }
        public int SelectedOrganizationId { get; set; }
        public PagingViewModel Paging { get; set; }
        public bool HasInviteRetailerPermission { get; set; }
        public bool HasEditRetailerPermission { get; set; }
        public bool HasDeleteRetailerPermission { get; set; }
        public bool HasViewRetailerOrdersPermission { get; set; }
        public string RequestCRSA_SortParam { get; set; }
    }
}
