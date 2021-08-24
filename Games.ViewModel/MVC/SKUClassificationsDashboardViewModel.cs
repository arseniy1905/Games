using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class SKUClassificationsDashboardViewModel:BaseAdminViewModel
    {
        public SKUClassificationsDashboardViewModel()
        {
            HasCreatePermission = true;
            HasUpdatePermission = true;
            HasDeletePermission = true;
            Paging = new PagingViewModel();
            ClassificationList = new List<SKUClassificationItem>();
        }
        public bool HasCreatePermission { get; set; }
        public bool HasUpdatePermission { get; set; }
        public bool HasDeletePermission { get; set; }
        public List<SKUClassificationItem> ClassificationList { get; set; }
        public PagingViewModel Paging { get; set; }
    }
}
