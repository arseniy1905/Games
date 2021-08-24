using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class HomePage
    {
        public int Id { get; set; }
        public string HomePageName { get; set; }
        public string CTABackgroundColor { get; set; }
        public string ContentBlockBackgroundColor { get; set; }
        public string FooterBackgroundColor { get; set; }

        public DateTime? HomePageStartDate { get; set; }
        public DateTime? HomePageEndDate { get; set; }
        public int TemplateId { get; set; }
        public int StatusId { get; set; }
        public int PageStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
