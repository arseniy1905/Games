using System;

namespace Games.DataModel
{
    public class ProductTagDataRuleAttributeSign
    {
        public int Id { get; set; }
        public int AttributeId { get; set; }
        public int SignId { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int StatusId { get; set; }
    }
}
