using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class HomePageFooter
    {
        public int Id { get; set; }
        public int HomePageId { get; set; }
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }
        public string BackgroundColor { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int ModifyBy { get; set; }
        public int StatusId { get; set; }
    }
}
