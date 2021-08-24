using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class CarouselDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionHtml { get; set; }
        public string DescriptionHtmlFr { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrlFr { get; set; }
        public int SortOrder { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }

    }
}
