using System;

namespace Games.DataModel
{
    public class ProductTagDataRuleAttribute
    {
        public int Id { get; set; }
        public int AttributeLevelId { get; set; }
        public string AttributeName { get; set; }
        public int AttributeTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int CreatedBy { get; set; }
        public int StatusId { get; set; }
    }
}
