using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class UploadDocumentStageViewModel : Common.RetailerinfoAbstractViewModel
    {
        public IEnumerable<UploadDocumentViewModel> UploadDocumentViewList { get; set; }
    }
}
