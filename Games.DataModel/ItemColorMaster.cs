using System;

namespace Games.DataModel
{
    public class ItemColorMaster
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public string ColorImageName { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
