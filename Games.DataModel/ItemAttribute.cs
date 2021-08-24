using System;

namespace Games.DataModel
{
    public class ItemAttribute
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public ItemAttributeMaster Attribute { get; set; }
        public int ItemNumber { get; set; }
        public string AttributeValue { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
