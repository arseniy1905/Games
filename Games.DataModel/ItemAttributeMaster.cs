using System;

namespace Games.DataModel
{
    public class ItemAttributeMaster
    {
        public int Id { get; set; }
        public string AttributeTypeName { get; set; }
        public string AttributeName { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
