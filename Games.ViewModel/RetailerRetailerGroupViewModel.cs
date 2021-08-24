using Games.ViewModel.Common;

namespace Games.ViewModel.MVC
{
    public class RetailerRetailerGroupViewModel
    {
        public RetailerRetailerGroupViewModel()
        {
            Paging = new PagingViewModel();
        }
        public int Id { get; set; }
        public string RetailerSearch { get; set; }
        public string RetailerName { get; set; }
        public string CROLNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string logo { get; set; }
        public string StoreClassification { get; set; }
        public PagingViewModel Paging { get; set; }
    }
}
