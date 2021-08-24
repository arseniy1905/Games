using System;

namespace Games.DataModel
{
    public class ItemRelationData
    {
        public int Id { get; set; }
        public string ItemNumber { get; set; }
        public string RelatedItemNumber { get; set; }
        public int RelationTypeId { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
