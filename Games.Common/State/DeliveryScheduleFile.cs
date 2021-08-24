using System;
using System.Collections.Generic;
using System.Text;

namespace Games.Common.State
{
    public class DeliveryScheduleFile
    {
        public DeliveryScheduleFile()
        {

        }
        public byte[] FileContent { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
