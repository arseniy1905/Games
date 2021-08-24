using System;
using System.Collections.Generic;
using System.Text;

namespace Games.ViewModel.MVC
{
    public class HomePagesItemViewModel
    {
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string StartEndDate { get; set; }
        public DateTime? PublishedDate { get; set; }
        public string StatusName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int RetailersCount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? HomePageStartDate { get; set; }
        public DateTime? HomePageEndDate { get; set; }
        public string CreatedByFirstName { get; set; }
        public string CreatedByLastName { get; set; }
    }
}
