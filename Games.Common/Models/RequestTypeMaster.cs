using System;

namespace Games.Common.Models
{
    [Serializable]
    public class RequestTypeMaster
    {
        public Int32 ID { get; set; }
        public String RequestType { get; set; }
        public String RequestTypeFr { get; set; }
        public Int32 StatusID { get; set; }
    }
}
