using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class CreateHomePageRetailerGroupMaping
    {
        public int Id { get; set; }
        public int HomePageId { get; set; }
        public int RetailerGroupId { get; set; }
        public int StatusId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.ParseExact(DateTime.Now.ToString("yyyy-MM-dd HH:mm"), "yyyy-MM-dd HH:mm", null);
        public int ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
