using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class AllocationPoolPageViewModel:BaseAdminViewModel
    {
        public AllocationPoolPageViewModel()
        {
            Paging = new PagingViewModel();
        }
        public PagingViewModel Paging { get; set; }
        public bool CanDeletePool { get; set; }
        public int OrganizationId { get; set; }
        public int LocationId { get; set; }
        public int OrderTotalId { get; set; }
        public string CurrentOrderWindow { get; set; }
        public IEnumerable<AllocationPoolListViewModel> AllocationPools { get; set; }
        public IEnumerable<AllocationPoolNotSubmittedLiewModel> NotSubmittedList { get; set; }
        public IEnumerable<AllocationPoolSubmittedOrderViewModel> SubmittedList { get; set; }
        public IEnumerable<AllocationPoolOrderHistoryViewModel> OrderHistoryList { get; set; }
        //public IEnumerable<SelectListItem> OrderTotalFilters { get; set; }
        public IEnumerable<SelectListItem> OrderStatuses { get; set; }

        public bool ForSubmittedOrders { get; set; }
    }
}
