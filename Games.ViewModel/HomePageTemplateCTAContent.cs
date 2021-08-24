using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class HomePageTemplateCTAContent
    {
        public List<HomPageTemplateCTADetails> homPageTemplateCTADetails { get; set; }
        public List<HomPageTemplateContentDetails> homPageTemplateContentDetails { get; set; }
    }

    public class HomPageTemplateCTADetails
    {
        public int HomaPageTemplateId { get; set; }
        public string CTAName { get; set; }
        public int CTATemplateID { get; set; }
        public int SortOrder { get; set; }
    }

    public class HomPageTemplateContentDetails
    {
        public int HomaPageTemplateId { get; set; }
        public string ContentBlockTemplateName { get; set; }
        public int ContentBlockTemplateID { get; set; }
        public int SortOrder { get; set; }
    }
}
