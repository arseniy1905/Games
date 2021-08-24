using System;

namespace Games.DataModel
{
    public class ServiceCallLog
    {
        public Int64 Id { get; set; }
        public int EventType { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string Attributes { get; set; }
        public string Endpoint { get; set; }
        public bool IsError { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
