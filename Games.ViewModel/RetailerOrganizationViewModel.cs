using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class RetailerOrganizationListViewModel : BaseAdminViewModel
    {
        public RetailerOrganizationListViewModel()
        {
            retailerOrganizations = new List<RetailerOrganizationViewModel>();
            Paging = new PagingViewModel();
        }
        public PagingViewModel Paging { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<RetailerOrganizationViewModel> retailerOrganizations { get; set; }
        public bool HasEditOrganizationPermission { get; set; }
        public bool HasCreateOrganizationPermission { get; set; }
        public bool HasDeleteOrganizationPermission { get; set; }
    }
    public class RetailerOrganizationViewModel
    {
        public int Id { get; set; }
        public string RetailerOrganizationName { get; set; }
        public string BusinessAddressStreet { get; set; }
        public int CorporateStoreCount { get; set; }
        public int NonCorporateStoreCount { get; set; }
        public string UploadedImagePath { get; set; }
        public bool HasRetailers { get; set; }
    }
}
