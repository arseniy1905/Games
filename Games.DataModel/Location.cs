using System;

namespace Games.DataModel
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameFr { get; set; }
        public string Address { get; set; }
        public int RetailerId { get; set; }
        public Retailer Retailer { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
