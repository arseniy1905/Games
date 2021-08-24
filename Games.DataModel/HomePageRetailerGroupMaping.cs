using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class HomePageRetailerGroupMaping
    {
        public int Id { get; set; }
        public int HomePageId { get; set; }
        public int RetailerGroupId { get; set; }
        
        public int StatusId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
