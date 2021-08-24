using System;

namespace Games.ViewModel.MVC
{
    public class RetailerGroupListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleteable { get; set; }
        public int RetailersCount { get; set; }
    }
}
