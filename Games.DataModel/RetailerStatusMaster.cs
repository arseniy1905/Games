using System;

namespace Games.DataModel
{
    [Serializable]
    public class RetailerStatusMaster
    {
        public int Id { get; set; }
        public string RetailerStatus { get; set; }
        public string RetailerStatusFr { get; set; }
        public StatusMaster Status { get; set; }
    }
}
