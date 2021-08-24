using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            AvailableBannersToDisplay = new List<AlertBannerInfoToDisplayViewModel>();
            Breadcrumbs = new List<BreadCrumbViewModel>();
        }
        public int RetailerPageID { get; set; }
        public int RetailerId { get; set; }
        public int SalesAccountPageID { get; set; }
        public bool IsSalesFlowPage { get; set; }
        public List<AlertBannerInfoToDisplayViewModel> AvailableBannersToDisplay { get; set; }
        public List<BreadCrumbViewModel> Breadcrumbs { get; set; }
        public bool IsValidOrderExplortTemplateLink { get; set; }
        public bool HasViewProductListPermission { get; set; }
        public bool HasViewProductDetailsPermission { get; set; }
        public bool HasAddItemsToCartPermission { get; set; }
        public bool HasSubmitOrderPermission { get; set; }
        public bool HasEditSubmittedOrderPermission { get; set; }
        public bool HasViewOrderDocumentsPermission { get; set; }
        public bool HasViewOrderHistoryPermission { get; set; }
        public bool EditSubittedOrderPermission { get; set; }
        public bool HasViewAccountBalancePermission { get; set; }
        public bool HasViewRetaileUsersPermission { get; set; }
        public bool HasCreateRetaileUsersPermission { get; set; }
        public bool HasEditRetaileUsersPermission { get; set; }
        public bool HasDeleteRetaileUsersPermission { get; set; }
        public bool HasEditRetaileUsersAccessPermission { get; set; }
        public bool HasLockUlockRetaileUsersPermission { get; set; }
        public bool HasViewRetailerStoresPermission { get; set; }
    }
}
