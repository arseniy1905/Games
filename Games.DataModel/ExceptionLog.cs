using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class ExceptionLog
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Url { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public DateTime LoggedDate { get; set; }
    }
}
