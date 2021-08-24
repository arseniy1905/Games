using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class OrganizationRetailerViewModel
    {
        public OrganizationRetailerViewModel()
        {
            Paging = new PagingViewModel();
        }
        public int Id { get; set; }
        public string RetailerSearch { get; set; }
        public string RetailerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string StoreType { get; set; }
        public string StoreClassification { get; set; }
        public string StoreAdmin { get; set; }
        public string StoreADM { get; set; }
        public PagingViewModel Paging { get; set; }
    }
}
