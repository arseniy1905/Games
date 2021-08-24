using Games.Common.Resources;
using System.ComponentModel.DataAnnotations;

namespace Games.ViewModel.MVC
{
    public class NDAAcceptanceViewModel
    {
        public string AcceptanceText { get; set; }
        [Required(ErrorMessageResourceName = "PleaseAccept", ErrorMessageResourceType = typeof(CommonResources))]
        public bool Accept { get; set; }
        public string AcceptText { get; set; }
        public string NextStepText { get; set; }
        public string NextStepAction { get; set; }
        public string DownloadAcceptanceUrl { get; set; }
    }
}
