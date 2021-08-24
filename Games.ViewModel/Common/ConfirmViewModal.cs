using Games.Common.Resources;

namespace Games.ViewModel.Common
{
    public class ConfirmViewModal
    {
        public ConfirmViewModal()
        {
            Body = string.Empty;
            Ok = CommonResources.Ok;
            Cancel = CommonResources.Cancel;
            Title = string.Empty;
        }
        public string Body { get; set; }
        public string Ok { get; set; }
        public string Cancel { get; set; }
        public string Title { get; set; }
    }
}
