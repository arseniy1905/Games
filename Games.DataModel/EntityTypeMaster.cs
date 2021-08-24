using System;

namespace Games.DataModel
{
    public class EntityTypeMaster
    {
        public int ID { get; set; }
        public string EntityType { get; set; }
        public string EntityTypeFr { get; set; }
        public StatusMaster Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
