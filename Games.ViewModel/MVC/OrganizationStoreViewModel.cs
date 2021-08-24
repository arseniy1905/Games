using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrganizationStoreViewModel : BaseViewModel
    {
        public OrganizationStoreViewModel()
        {
            StoreList = new List<OrganizationStoreDetailViewModel>();
            Paging = new PagingViewModel();
            Documents = new List<OrderDocumentViewModel>();
            OrderStatuses = new List<SelectListItem>();
        }
        public List<OrganizationStoreDetailViewModel> StoreList { get; set; }
        public PagingViewModel Paging { get; set; }
        public int UserRole { get; set; }
        public List<OrderDocumentViewModel> Documents { get; set; }
        public List<SelectListItem> OrderStatuses { get; set; }
        public List<SelectListItem> OrderTotalRanges { get; set; }
        public bool IsReadOnlyMode { get; set; }

    }
    public class OrganizationStoreDetailViewModel
    {
        public int RetailerId { get; set; }
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string AdminEmail { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string NextOrderDate { get; set; }
        public string NextDeliveryDate { get; set; }
        public string FullTextSearch { get; set; }
    }
}
