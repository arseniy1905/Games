using Games.ViewModel.Common;
using Games.ViewModel.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class AuditHistoryViewModel:BaseAdminViewModel
    {
        public AuditHistoryViewModel()
        {
            AuditHistoryList = new List<AuditHistoryDetailViewModel>();
            Paging = new PagingViewModel();
            RoleList = new List<SelectViewModel>();
            ActionTypeList = new List<SelectViewModel>();
        }
        public List<AuditHistoryDetailViewModel> AuditHistoryList { get; set; }
        public PagingViewModel Paging { get; set; }
        public bool HasViewUserPermission { get; set; }
        public bool HasUpdateUserPermission { get; set; }
        public bool HasCreateUserPermission { get; set; }
        public bool HasDeleteUserPermission { get; set; }
        public bool HasViewRetailUserPermission { get; set; }
        public bool HasDeleteRetailUserPermission { get; set; }
        public bool HasEditRetailUserPermission { get; set; }
        public bool HasViewEditRetailUserAccessPermission { get; set; }
        public List<SelectViewModel> RoleList { get; set; }
        public List<SelectViewModel> UserList { get; set; }
        public List<SelectViewModel> ActionTypeList { get; set; }
        public DateTime StartDateTime { get; set; } = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
        [MustBeLaterThan("StartDateTime")]
        public DateTime? EndDateTime { get; set; } = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
    }
}
