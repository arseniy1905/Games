using System;

namespace Games.DataModel
{
    public class ProductTagDataRule
    {
        public int Id { get; set; }
        public int ProductTagId { get; set; }
        public int AttributeId { get; set; }
        public int SignId { get; set; }
        public string Value { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int ValueId { get; set; }
    }
}
