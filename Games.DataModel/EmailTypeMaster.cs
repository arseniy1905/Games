using System;

namespace Games.DataModel
{
    public class EmailTypeMaster
    {
        public Int32 Id { get; set; }
        public string EmailType { get; set; }
        public string EmailTypeFr { get; set; }
        public Int32 StatusId { get; set; }
        public StatusMaster Status { get; set; }
    }
}
