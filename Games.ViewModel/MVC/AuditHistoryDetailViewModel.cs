using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class AuditHistoryDetailViewModel
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public string EntityType { get; set; }
        public string EntityName { get; set; }
        public string ActionName { get; set; }
        public string ChangeMade { get; set; }

    }
}
