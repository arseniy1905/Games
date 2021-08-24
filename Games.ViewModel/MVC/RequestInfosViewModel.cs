using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class RequestInfosViewModel:BaseAdminViewModel
    {
        public RequestInfosViewModel()
        {
            RequestInfoList = new List<RequestInfoDetailViewModel>();
            RequestTypeList = new List<SelectListItem>();
            RequestStatusList = new List<SelectListItem>();
            Paging = new PagingViewModel();
        }
        public List<RequestInfoDetailViewModel> RequestInfoList { get; set; }
        public List<SelectListItem> RequestTypeList { get; set; }
        public int SelectedType { get; set; }
        public List<SelectListItem> RequestStatusList { get; set; }
        public int SelectedStatus { get; set; }
        public PagingViewModel Paging { get; set; }
        public string RequestTypeSortParam { get; set; }
        public string RequestStatusSortParam { get; set; }
        public string RequestLastUpdatedSortParam { get; set; }
        public bool HasViewApplicationPermission { get; set; }
        public bool HasDeleteApplicationPermission { get; set; }
    }
}
