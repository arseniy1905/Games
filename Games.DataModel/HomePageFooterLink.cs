using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class HomePageFooterLink
    {
        public int Id { get; set; }
        public int FooterCategoryId { get; set; }
        public int LinkType { get; set; }
        public string LinkImagePath { get; set; }
        public string LinkImageOriginalName { get; set; }
        public string URLLinkName { get; set; }
        public string URLLink { get; set; }
        public int LinkDisplayOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int StatusId { get; set; }
    }
}
