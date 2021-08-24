using System;

namespace Games.Common.Models
{
    [Serializable]
    public class RequestStatusMaster
    {
        public Int32 ID { get; set; }
        public Int32 RequestTypeID { get; set; }
        public String RequestStatus { get; set; }
        public String RequestStatusFr { get; set; }
        public Int32 StatusID { get; set; }
    }
}
