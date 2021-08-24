using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class FileViewModel
    {
        public FileViewModel()
        {
            FileName = string.Empty;
            ContentType = string.Empty;
            Content = new List<byte>().ToArray();
        }
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
    }
}
