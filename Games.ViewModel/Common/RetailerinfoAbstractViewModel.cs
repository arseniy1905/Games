using Games.ViewModel.MVC;
using System.Collections.Generic;

namespace Games.ViewModel.Common
{
    public abstract class RetailerinfoAbstractViewModel
    {
        public RetailerinfoAbstractViewModel()
        {
            Stages = new List<UserInfoStageItemViewModel>();
            NextStepText = string.Empty;
            NextStepAction = string.Empty;
            NextStepController = string.Empty;
            NextStepIndex = -1;
            Validate = true;
            ConfirmViewModal = new ConfirmViewModal();
        }
        public ConfirmViewModal ConfirmViewModal { get; set; }
        public List<UserInfoStageItemViewModel> Stages { get; set; }
        public string NextStepText { get; set; }
        public string NextStepAction { get; set; }
        public string NextStepController { get; set; }
        public bool IsActive { get; set; }
        public bool Validate { get; set; }
        public int NextStepIndex { get; set; }
        public bool ShowSaveMessage { get; set; }
        public string SuccessText { get; set; }
        public string ErrorMessage { get; set; }

    }
}
