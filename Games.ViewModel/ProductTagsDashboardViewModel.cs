using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
namespace Games.ViewModel.MVC
{
    public class ProductTagsDashboardViewModel:BaseAdminViewModel
    {
        public ProductTagsDashboardViewModel()
        {
            TagList = new List<ProductTagInfoViewModel>();
            Paging = new PagingViewModel();
            Tabs = new List<TabViewModel>();
        }
        public List<ProductTagInfoViewModel> TagList { get; set; }
        public PagingViewModel Paging { get; set; }
        public int TagTypeId { get; set; }
        public List<TagTypeViewModel> TagTypes { get; set; }
        public bool HasUpdatePermission { get; set; }
        public bool HasCreatePermission { get; set; }
        public bool HasDeletePermission { get; set; }
        public List<TabViewModel> Tabs { get; set; }
    }

    public class ProductTagInfoViewModel
    {
        public int Id { get; set; }
        public string NameOfTag { get; set; }
        public bool IsTagSearchable { get; set; }
        public bool IsSalesFlow { get; set; }
        public int ColorId { get; set; }
        public string ColorCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string ProductTagType { get; set; }
        public int ProductTagTypeId { get; set; }
        public int NoOfProducts { get; set; }
        public int TagNumber { get; set; }
    }

    public class TagTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
