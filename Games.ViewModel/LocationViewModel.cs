using Games.DataModel;
using System;

namespace Games.ViewModel.MVC
{
    public class LocationViewModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public DateTime LastUpdated { get; set; }
        public StatusMaster Status { get; set; }
        public string Action { get; set; }
    }
}
