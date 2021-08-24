using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;

namespace Games.ViewModel.MVC
{
    public class CreateRetailerGroupViewModel:BaseAdminViewModel
    {
        public CreateRetailerGroupViewModel()
        {
            Paging = new PagingViewModel();
            SelectedRetailers = new List<int>();
            retailerRetailerGroup = new List<RetailerRetailerGroupViewModel>();
        }

        public PagingViewModel Paging { get; set; }
        public int Id { get; set; }
        [Required]
        [MaxLength(225)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Color is required.")]
        [Range(1, 10000, ErrorMessage = "Color is Required.")]
        public int ColorId { get; set; }
        public List<ColorPalletListViewModel> ColorPalletList { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //public List<int> SelectedUsers { get; set; }
        public string hdnselectedRetailers { get; set; }
        public bool IsDeleteable { get; set; }
        public bool HasDeleteRetailerGroupPermission { get; set; }
       // public List<RetailListRetailerGroupViewModel> retailerGroupRetailerViewModel { get; set; }
        public List<RetailerRetailerGroupViewModel> retailerRetailerGroup { get; set; }
        public List<int> SelectedRetailers { get; set; }

    }
}
