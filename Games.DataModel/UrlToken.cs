using System;

namespace Games.DataModel
{
    public class UrlToken
    {
        public Int32 Id { get; set; }
        public string Token { get; set; }
        public Int32 TokenTypeID { get; set; }
        public DateTime CreatedDate { get; set; }
        public User Creator { get; set; }
        public int CreatorId { get; set; }
        public Int32 ValidCount { get; set; }
        public Int32 UsedCount { get; set; }
        public Int32 ValidMinutes { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
