using Games.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class HomePagesViewModel : BaseAdminViewModel
    {
        public HomePagesViewModel()
        {
            PagesList = new List<HomePagesItemViewModel>();
            Paging = new PagingViewModel();
            
            SortBy = "";
        }
        public List<HomePagesItemViewModel> PagesList { get; set; }
        public PagingViewModel Paging { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool HasUpdateHomePagePermission { get; set; }
        public bool HasCreateHomePagePermission { get; set; }
        public bool HasDeleteHomePagePermission { get; set; }
        public bool HasPublishHomePagePermission { get; set; }
        
        
    }
}
