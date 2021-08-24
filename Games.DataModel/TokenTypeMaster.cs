using System;

namespace Games.DataModel
{
    public class TokenTypeMaster
    {
        public Int32 Id { get; set; }
        public string TokenType { get; set; }
        public string TokenTypeFR { get; set; }
        public int ValidMinutes { get; set; }
        public int ValidCount { get; set; }
    }
}
