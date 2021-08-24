using System;

namespace Games.DataModel
{
    public class UserType
    {

        public int Id { get; set; }
        public string TypeName { get; set; }
        public int StatusId { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
