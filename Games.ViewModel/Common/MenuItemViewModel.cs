using Games.ViewModel.MVC;
using System;
using System.Collections.Generic;

namespace Games.ViewModel.Common
{
    [Serializable]
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Action { get; set; }
        public string Controller { get; set; }
        public string Title { get; set; }
        public string TitleFr { get; set; }
        public bool Selected { get; set; }
        public string ToolTip { get; set; }
        public string ToolTipFr { get; set; }
        public IEnumerable<PermissionViewModel> Permissions { get; set; }
    }


}
