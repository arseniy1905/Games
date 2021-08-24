using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Common.State
{
    [Serializable]
    public class Error
    {
        //public Error()
        //{
        //    Exception2 = new Exception();
        //}
        
        //public Exception Exception2 { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string InnerException { get; set; }

        public string Source { get; set; }
        public string Url { get; set; }
    }
}
