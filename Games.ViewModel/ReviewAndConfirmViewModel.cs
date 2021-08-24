using Games.ViewModel.Common;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class ReviewAndConfirmViewModel
    {
        public int RequestId { get; set; }
        public ReviewAndConfirmViewModel()
        {
            ConfirmViewModal = new ConfirmViewModal();
        }
        public RetailerGetViewModel retailerViewModel { get; set; }
        public RetailerStoreDetailGetViewModel retailerStoreDetailGetViewModel { get; set; }
        public IEnumerable<RetailerStoreHoursViewModel> retailerStoreHoursViewModel { get; set; }
        public IEnumerable<RetailerStoreDocumentViewModel> retailerStoreDocumentViewModel { get; set; }
        public List<RetailerAddressViewModel> retailerAddressViewModel { get; set; }
        public RequestInfoViewModel requestInfoViewModel { get; set; }
        //public List<Request>
        public ConfirmViewModal ConfirmViewModal { get; set; }

    }
}
