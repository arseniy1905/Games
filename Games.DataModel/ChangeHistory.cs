using System;

namespace Games.DataModel
{
    public class ChangeHistory
    {
        public int Id { get; set; }
        public int ChangeTypeId { get; set; }
        public ActionTypeMaster ActionType { get; set; }
        public string TableName { get; set; }
        public string TablePrimaryKeyValues { get; set; }
        public string ColumnName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateLogged { get; set; }
        public int LoggedByUserId { get; set; }
        public User LoggedByUser { get; set; }
    }
}
