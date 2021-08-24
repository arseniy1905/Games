using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class AuditHistory
    {
        public long Id { get; set; }
        public string EntityType { get; set; }
        public string EntityId { get; set; }
        public string EntytyDesc { get; set; }
        public int ActionTypeId { get; set; }
        public string ActionType { get; set; }
        public string ActionDetails { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        


    }
}
