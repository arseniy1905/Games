using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class HomePageTemplateMaster
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string TemplateImage { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public DateTime ModifiedDate { get; set; }
    }
}
