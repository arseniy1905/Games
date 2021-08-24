using System;
using System.Collections.Generic;
using System.Text;

namespace Games.DataModel
{
    public class RelatedProductRuleDetail
    {
        public int Id { get; set; }
        public int RelatedProductRuleId { get; set; }
        public int AttributeId { get; set; }
        public int SignId { get; set; }
        public string Value { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public int? ValueId { get; set; }
        public int ProductRelationTypeId { get; set; }
    }
}
