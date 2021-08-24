using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class HomePageTemplateContentBlockMaster
    {
        public int Id { get; set; }
        public string ContentBlockTemplateName { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? NoOfBlocksInRow { get; set; }
        public string TemplateHtml { get; set; }
    }
}
