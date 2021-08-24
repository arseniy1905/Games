using Games.ViewModel.Common;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Games.ViewModel.MVC
{
    public class AdditionalDocumentsViewModel : RetailerinfoAbstractViewModel
    {
        [BindProperty(Name = "uploads")]
        public IEnumerable<UploadDocumentViewModel> UploadDocumentViewModel { get; set; }

        public AdditionalDocumentsViewModel()
        {
            OnboardProcessComments = new OnboardingProcessViewModel();
        }
        public int RetailerStatusId { get; set; }
        public OnboardingProcessViewModel OnboardProcessComments { get; set; }
        public bool HasEditRetailerPermission { get; set; }
    }
}
